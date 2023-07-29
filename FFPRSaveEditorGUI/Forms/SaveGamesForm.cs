using FFPRSaveEditor.Common;
using FFPRSaveEditor.Common.Models;
using Newtonsoft.Json;
using System.Diagnostics;

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
            this.Size = new Size(1024, 625);
            this.Left = Math.Max(0, this.Left - ((this.Size.Width - oldSize.Width) / 2));
            this.Top = Math.Max(0, this.Top - ((this.Size.Height - oldSize.Height) / 2));
        }

        private void LoadSaveGames(bool loadAll) {
            string[] filenames = Directory.GetFiles(directoryName, "*.", SearchOption.TopDirectoryOnly);

            ImageList il = new ImageList();
            il.ImageSize = new Size(256, 144);
            lvSaveGames.LargeImageList = il;

            foreach (var filename in filenames) {
                // Skip non-game files
                if (filename.EndsWith("2E4HxIyL+Mvaahk1GRNNOgKrO4vDSSm72kHLbVt71hg=")) {
                    // Not sure what this file is
                    continue;
                } else if (filename.EndsWith("dp3fS2vqP7GDj8eF72YKqbT7FIAF=e7Shy2CsTITm2E=")) {
                    // Visitted locations and monster kill counts
                    continue;
                } else if (filename.EndsWith("V=SfwyU31ksiHpTxO7Rg2aBJrA18kSKvtF4jvDB4hRE=")) {
                    // Settings file
                    continue;
                }

                // Skip this file if we only want to show the autosave and quicksave
                bool shouldLoad = loadAll || filename.EndsWith("7nCxyzTwG31W3Zlg70mo751W8ETH1n+Km0dWOzRU84Y=") || filename.EndsWith("Rl18osV3e9kPX9SMWQj8mqShFpTUmu1lf6Mb=FVVfqk=");
                if (!shouldLoad) {
                    continue;
                }

                // Load save file and decrypt.  Only verify when running via the debugger to speed things up.
                var save = SaveGame.Load(filename, Debugger.IsAttached);

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

        private void lvSaveGames_Click(object sender, EventArgs e) {
            var lv = (sender as ListView);
            if (lv.SelectedItems.Count > 0) {
                string filename = lv.SelectedItems[0].Tag.ToString();

                BaseSaveGame save;
                try {
                    save = SaveGame.Load(filename, true);
                } catch (InvalidDataException) {
                    MessageBox.Show("Error loading save game.  Please contact the developers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (var form = new UserDataForm(save)) {
                    if (form.ShowDialog() == DialogResult.OK) {
                        SaveGame.Save(filename, save);
                    }
                }
            }
        }
    }
}
