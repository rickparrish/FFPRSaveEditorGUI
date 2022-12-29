using FFPRSaveEditor.Common.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFPRSaveEditorGUI.Forms {
    public partial class UserDataForm : Form {
        private SaveGame save;
        private UserData userData;

        public UserDataForm() {
            InitializeComponent();
        }

        public UserDataForm(SaveGame save) {
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
