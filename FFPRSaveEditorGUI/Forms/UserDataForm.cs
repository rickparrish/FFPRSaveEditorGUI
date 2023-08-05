using FFPRSaveEditor.Common.Models;

namespace FFPRSaveEditorGUI.Forms {
    public partial class UserDataForm : Form {
        private BaseSaveGame save;

        public UserDataForm() {
            InitializeComponent();
        }

        public UserDataForm(BaseSaveGame save) {
            InitializeComponent();

            this.save = save;
            
            UpdateDisplay();
        }

        private void cmdCharacterEditor_Click(object sender, EventArgs e) {
            using (var form = new CharacterEditorForm(save)) {
                form.ShowDialog();
            }
        }

        private void cmdItemEditor_Click(object sender, EventArgs e) {
            using (var form = new ItemEditorForm(save)) {
                form.ShowDialog();
            }
        }

        private void lblGil_Click(object sender, EventArgs e) {
            save.Gold = Helpers.GetInt("Enter a new Gold amount", "Gold", save.Gold);
            UpdateDisplay();
        }

        private void UpdateDisplay() {
            this.Text = $"Final Fantasy {save.Version} - ";

            pbScreen.BackgroundImage = save.Thumbnail;

            if (save.IsAutosave) {
                lblSaveId.Text = "Autosave";
            } else if (save.IsQuickSave) {
                lblSaveId.Text = "File 00 (Quick Save)";
            } else {
                lblSaveId.Text = $"File {save.id:D2}";
            }
            this.Text += lblSaveId.Text;
    
            lblTimeStamp.Text = save.timeStamp;
            lblPlayTime.Text = $"Play Time: {Helpers.SecToHMS(save.PlayTimeInSeconds)}";

            lblGil.Text = save.Gold.ToString("n0");
            // TODOX Maybe add these values a display only stats:
            //       owendCrystalFlags
            //       escapeCount
            //       battleCount
            //       openChestCount
            //       saveCompleteCount
            //       monstersKilledCount
        }

        private void UserDataForm_FormClosing(object sender, FormClosingEventArgs e) {
            // Don't prompt if they clicked Save
            if (this.DialogResult == DialogResult.OK) {
                return;
            }

            var result = MessageBox.Show("Would you like to save your changes?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result) {
                case DialogResult.Yes:
                    this.DialogResult = DialogResult.OK;
                    break;

                case DialogResult.No:
                    this.DialogResult = DialogResult.Cancel;
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;

            }
        }
    }
}
