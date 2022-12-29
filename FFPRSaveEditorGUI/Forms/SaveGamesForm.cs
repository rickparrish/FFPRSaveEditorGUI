using FFPRSaveEditor.Common;
using Newtonsoft.Json;

namespace FFPRSaveEditorGUI.Forms {
    public partial class SaveGamesForm : Form {
        private string directoryName;
        private Type saveType;

        public SaveGamesForm() {
            InitializeComponent();
        }

        public SaveGamesForm(string directoryName, Type saveType) {
            InitializeComponent();

            this.directoryName = directoryName;
            this.saveType = saveType;

            // Only load the autosave by default
            LoadSaveGames("7nCxyzTwG31W3Zlg70mo751W8ETH1n+Km0dWOzRU84Y=");
        }

        private void cmdLoadAll_Click(object sender, EventArgs e) {
            // Reload list to show all save games
            cmdLoadAll.Visible = false;
            lvSaveGames.Items.Clear();
            LoadSaveGames("*.");

            // Increase height and re-center vertically (175 is half the difference between old 250 height and new 600 height)
            this.Size = new Size(this.Size.Width, 600);
            this.Top = Math.Max(0, this.Top - 175);
        }

        private void LoadSaveGames(string searchPattern) {
            string[] filenames = Directory.GetFiles(directoryName, searchPattern, SearchOption.TopDirectoryOnly);

            ImageList il = new ImageList();
            il.ImageSize = new Size(256, 144);
            lvSaveGames.LargeImageList = il;

            foreach (var filename in filenames) {
                // Load save file and decrypt
                string encryptedData = File.ReadAllText(filename);
                string jsonData = SaveGame.Decrypt(encryptedData);

                // Confirm it's a save and not a settings file
                if (jsonData.Contains("userData")) {
                    var save = JsonConvert.DeserializeObject<FFPRSaveEditor.Common.Models.BaseModels.SaveGame2>(jsonData);

                    var lvi = new ListViewItem();

                    lvi.Tag = filename;

                    if (save.id == 21) {
                        lvi.Text = "Autosave";
                    } else if (save.id == 22) {
                        lvi.Text = "File 00 (Quick Save)"; // TODOX "File 00" is a hack to put it second in the list
                    } else {
                        lvi.Text = $"File {save.id:D2}";
                    }

                    lvi.SubItems.Add(save.timeStamp);
                    lvi.SubItems.Add($"Time: {Helpers.SecToHMS(save.userData.playTime)}");

                    lvi.ImageIndex = il.Images.Count;
                    il.Images.Add(Image.FromStream(new MemoryStream(Convert.FromBase64String(save.pictureData))));

                    lvSaveGames.Items.Add(lvi);
                }
            }
        }

        private void lvSaveGames_DoubleClick(object sender, EventArgs e) {
            var lv = (sender as ListView);
            if (lv.SelectedItems.Count > 0) {
                string filename = lv.SelectedItems[0].Tag.ToString();

                string encryptedData = File.ReadAllText(filename);
                string jsonData = SaveGame.Decrypt(encryptedData);
                var save = JsonConvert.DeserializeObject(jsonData, saveType);

                using (var form = new UserDataForm((FFPRSaveEditor.Common.Models.BaseModels.SaveGame)save)) {
                    if (form.ShowDialog() == DialogResult.OK) {
                        jsonData = JsonConvert.SerializeObject(save);
                        encryptedData = SaveGame.Encrypt(jsonData);
                        File.WriteAllText(filename, encryptedData);
                    }
                }
            }
        }
    }
}
