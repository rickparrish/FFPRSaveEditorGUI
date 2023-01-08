using FFPRSaveEditor.Common;
using FFPRSaveEditor.Common.Models;
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

            // Only load the autosave and quicksave by default
            LoadSaveGames(false);
        }

        private void cmdLoadAll_Click(object sender, EventArgs e) {
            // Reload list to show all save games
            cmdLoadAll.Visible = false;
            lvSaveGames.Items.Clear();
            LoadSaveGames(true);

            // Increase height and re-center vertically
            var oldSize = new Size(this.Size.Width, this.Size.Height);
            this.Size = new Size(1000, 625);
            this.Left = Math.Max(0, this.Left - ((this.Size.Width - oldSize.Width) / 2));
            this.Top = Math.Max(0, this.Top - ((this.Size.Height - oldSize.Height) / 2));
        }

        private void LoadSaveGames(bool loadAll) {
            string[] filenames = Directory.GetFiles(directoryName, "*.", SearchOption.TopDirectoryOnly);

            ImageList il = new ImageList();
            il.ImageSize = new Size(256, 144);
            lvSaveGames.LargeImageList = il;

            foreach (var filename in filenames) {
                // Skip this file if we only want to show the autosave and quicksave
                bool shouldLoad = loadAll || filename.EndsWith("7nCxyzTwG31W3Zlg70mo751W8ETH1n+Km0dWOzRU84Y=") || filename.EndsWith("Rl18osV3e9kPX9SMWQj8mqShFpTUmu1lf6Mb=FVVfqk=");
                if (!shouldLoad) {
                    continue;
                }

                // Load save file and decrypt
                string encryptedData = File.ReadAllText(filename);
                string jsonData = SaveGame.Decrypt(encryptedData);

                // Confirm it's a save and not a settings file
                if (jsonData.Contains("userData")) {
                    var save = JsonConvert.DeserializeObject<BaseSaveGame2>(jsonData);

                    var lvi = new ListViewItem();

                    lvi.Tag = filename;

                    if (save.id == 21) {
                        lvi.Text = "Autosave";
                    } else if (save.id == 22) {
                        lvi.Text = "File 00 (Quick Save)";
                    } else {
                        lvi.Text = $"File {save.id:D2}";
                    }

                    lvi.SubItems.Add(save.timeStamp);
                    lvi.SubItems.Add($"Play Time: {Helpers.SecToHMS(save.userData.playTime)}");

                    lvi.ImageIndex = il.Images.Count;
                    il.Images.Add(Image.FromStream(new MemoryStream(Convert.FromBase64String(save.pictureData))));

                    lvSaveGames.Items.Add(lvi);
                }
            }
        }

        private void lvSaveGames_Click(object sender, EventArgs e) {
            var lv = (sender as ListView);
            if (lv.SelectedItems.Count > 0) {
                string filename = lv.SelectedItems[0].Tag.ToString();

                string encryptedData = File.ReadAllText(filename);
                string jsonData = SaveGame.Decrypt(encryptedData);
                var save = JsonConvert.DeserializeObject(jsonData, saveType);

                using (var form = new UserDataForm((BaseSaveGame)save)) {
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
