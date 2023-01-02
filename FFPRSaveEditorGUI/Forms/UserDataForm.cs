// TODOX List:
// - Add a cancel button, which should prompt to confirm throwing away changes

using FFPRSaveEditor.Common.Models;

namespace FFPRSaveEditorGUI.Forms {
    public partial class UserDataForm : Form {
        private BaseSaveGame save;
        private UserData userData;

        public UserDataForm() {
            InitializeComponent();
        }

        public UserDataForm(BaseSaveGame save) {
            InitializeComponent();

            this.save = save;
            this.userData = ((dynamic)save).userData;
            
            UpdateDisplay();
        }

        private void cmdCharacterEditor_Click(object sender, EventArgs e) {
            using (var form = new CharacterEditorForm(userData.ownedCharacterList.target, save.GetType())) {
                form.ShowDialog();
            }
        }

        private void cmdItemEditor_Click(object sender, EventArgs e) {
            using (var form = new ItemEditorForm(userData.normalOwnedItemList.target, save.GetType())) {
                form.ShowDialog();
            }
        }

        private void lblGil_Click(object sender, EventArgs e) {
            userData.owendGil = Helpers.GetInt("Enter a new Gil/Gold amount", "Gil/Gold", userData.owendGil);
            UpdateDisplay();
        }

        private void UpdateDisplay() {
            pbScreen.BackgroundImage = Image.FromStream(new MemoryStream(Convert.FromBase64String(save.pictureData)));

            lblGil.Text = userData.owendGil.ToString("n0");
            // TODOX Maybe add these values a display only stats:
            //       owendCrystalFlags
            //       escapeCount
            //       battleCount
            //       openChestCount
            //       saveCompleteCount
            //       monstersKilledCount
        }
    }
}
