// TODOX List:
// - Add a panel at the bottom that allows adding a new item
//   - Dropdownlist to show items user doesn't have yet

using FFPRSaveEditor.Common.Models;
using System.Data;

namespace FFPRSaveEditorGUI.Forms {
    public partial class ItemEditorForm : Form {
        private BaseSaveGame save;
        private UserData userData;

        public ItemEditorForm() {
            InitializeComponent();
        }

        public ItemEditorForm(BaseSaveGame save) {
            InitializeComponent();

            this.save = save;
            this.userData = ((dynamic)save).userData;

            UpdateDisplay();
        }

        private void cmdAddItem_Click(object sender, EventArgs e) {
            if (!int.TryParse(txtContentId.Text, out int contentId)) {
                MessageBox.Show("Content ID must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCount.Text, out int count)) {
                MessageBox.Show("Count must be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((count < 1) || (count > 99)) {
                MessageBox.Show("Count must be between 1 and 99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userData.normalOwnedItemList.target.Any(x => x.contentId == contentId)) {
                MessageBox.Show($"You already have '{NormalItems.GetName(contentId, save.GetType())}' in your inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userData.normalOwnedItemList.target.Add(new NormalOwnedItemList_Target() {
                contentId = contentId,
                count = count
            });
            userData.normalOwnedItemSortIdList.target.Add(contentId);

            UpdateDisplay();

            txtContentId.Text = "";
            txtCount.Text = "1";
        }

        private int GetInt(string name, int value) {
            return Helpers.GetInt($"Enter the number of {name} you want", name, value, 1, 99);
        }

        private void lvItems_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                var item = (NormalOwnedItemList_Target)lvItems.SelectedItems[0].Tag;

                item.count = GetInt(NormalItems.GetName(item.contentId, save.GetType()), item.count);
         
                UpdateDisplay();
            }
        }

        private void UpdateDisplay() {
            lvItems.Items.Clear();

            foreach (var item in userData.normalOwnedItemList.target.Where(x => !NormalItems.GetName(x.contentId, save.GetType()).Contains("N/A", StringComparison.OrdinalIgnoreCase))) {
                var lvi = new ListViewItem();

                lvi.Tag = item;
                lvi.Text = NormalItems.GetName(item.contentId, save.GetType());
                lvi.SubItems.Add(item.count.ToString());

                lvItems.Items.Add(lvi);
            }
        }
    }
}
