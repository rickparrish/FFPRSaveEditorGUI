namespace FFPRSaveEditorGUI.Forms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void pbFF1_DoubleClick(object sender, EventArgs e) {
            ShowSaveGamesForm("Final Fantasy PR", typeof(FFPRSaveEditor.Common.Models.FF1Models.SaveGame));
        }

        private void pbFF2_DoubleClick(object sender, EventArgs e) {
            MessageBox.Show("Sorry, Final Fantasy 2 is not supported yet", "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void pbFF3_DoubleClick(object sender, EventArgs e) {
            MessageBox.Show("Sorry, Final Fantasy 3 is not supported yet", "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void pbFF4_DoubleClick(object sender, EventArgs e) {
            ShowSaveGamesForm("Final Fantasy IV PR", typeof(FFPRSaveEditor.Common.Models.FF4Models.SaveGame));
        }

        private void pbFF5_DoubleClick(object sender, EventArgs e) {
            MessageBox.Show("Sorry, Final Fantasy 5 is not supported yet", "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void pbFF6_DoubleClick(object sender, EventArgs e) {
            ShowSaveGamesForm("Final Fantasy VI PR", typeof(FFPRSaveEditor.Common.Models.FF6Models.SaveGame));
        }

        private void ShowSaveGamesForm(string ffDirectoryName, Type saveType) {
            // Set the initial directory to the %USERPROFILE%\Documents\My Games\FINAL FANTASY PR\Steam directory
            string initialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", ffDirectoryName, "Steam");

            // Check how many subdirectories under the initial directory there are -- if just one, use it as the initial directory
            var subdirectories = Directory.GetDirectories(initialDirectory);
            if (subdirectories.Length == 1) {
                initialDirectory = subdirectories[0];
            }

            using (var dialog = new FolderBrowserDialog()) {
                dialog.InitialDirectory = initialDirectory;
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK) {
                    using (var form = new SaveGamesForm(dialog.SelectedPath, saveType)) {
                        form.ShowDialog();
                    }
                }
            }
        }
    }
}