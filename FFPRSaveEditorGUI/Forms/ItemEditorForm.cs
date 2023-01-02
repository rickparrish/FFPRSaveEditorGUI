// TODOX List:
// - Add a panel at the bottom that allows adding a new item
//   - Dropdownlist to show items user doesn't have yet
//   - Textbox for the count
//   - Button to add to collections
//   - Call UpdateDisplay after clicking button

using FFPRSaveEditor.Common.Models;
using System.Data;

namespace FFPRSaveEditorGUI.Forms {
    public partial class ItemEditorForm : Form {
        private List<NormalOwnedItemList_Target> items;
        private Type saveType;
        private List<int> unequppedContentIds = new List<int>() { 62, 130, 131, 132, 133 };

        public ItemEditorForm() {
            InitializeComponent();
        }

        public ItemEditorForm(List<NormalOwnedItemList_Target> items, Type saveType) {
            InitializeComponent();

            this.items = items;
            this.saveType = saveType;

            UpdateDisplay();
        }

        private int GetInt(string name, int value) {
            return Helpers.GetInt($"Enter the number of {name} you want", name, value, 1, 99);
        }

        private void lvItems_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                var item = (NormalOwnedItemList_Target)lvItems.SelectedItems[0].Tag;

                item.count = GetInt(NormalItems.GetName(item.contentId, saveType), item.count);
         
                UpdateDisplay();
            }
        }

        private void UpdateDisplay() {
            lvItems.Items.Clear();

            foreach (var item in items.Where(x => !unequppedContentIds.Contains(x.contentId))) {
                var lvi = new ListViewItem();

                lvi.Tag = item;
                lvi.Text = NormalItems.GetName(item.contentId, saveType);
                lvi.SubItems.Add(item.count.ToString());

                lvItems.Items.Add(lvi);
            }
        }
    }
}
