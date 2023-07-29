using FFPRSaveEditor.Common.Models;
using System.Data;

namespace FFPRSaveEditorGUI.Forms {
    public partial class ItemEditorForm : Form {
        private ListViewColumnSorter columnSorter;
        private BaseSaveGame save;

        public ItemEditorForm() {
            InitializeComponent();
        }

        public ItemEditorForm(BaseSaveGame save) {
            InitializeComponent();

            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            columnSorter = new ListViewColumnSorter();
            this.lvItems.ListViewItemSorter = columnSorter;

            this.save = save;

            UpdateDisplay();

            columnSorter.Order = SortOrder.Ascending;
            columnSorter.SortColumn = 0;
            this.lvItems.Sort();
        }

        private void AddNOfEachItem(int count) {
            if (MessageBox.Show($"Are you sure you want to give yourself {count} of each item?", $"Confirm Add {count}", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            foreach (var item in Items.GetItems(save.GetType()).Where(x => x.name != "None")) {
                var lvi = new ListViewItem();

                OwnedItemList_Target inventoryItem = null;
                if (!item.isKeyItem) {
                    inventoryItem = save.userData.normalOwnedItemList.target.SingleOrDefault(x => x.contentId == item.contentId);

                    if (inventoryItem == null) {
                        inventoryItem = new OwnedItemList_Target() {
                            contentId = item.contentId,
                            count = count,
                        };
                        save.userData.normalOwnedItemList.target.Add(inventoryItem);
                        save.userData.normalOwnedItemSortIdList.target.Add(item.contentId);
                    } else {
                        inventoryItem.count = count;
                    }
                }
            }

            UpdateDisplay();
        }

        private int GetInt(string name, int value) {
            return Helpers.GetInt($"Enter the number of {name} you want", name, value, 1, 99);
        }

        private void lvItems_ColumnClick(object sender, ColumnClickEventArgs e) {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == columnSorter.SortColumn) {
                // Reverse the current sort direction for this column.
                if (columnSorter.Order == SortOrder.Ascending) {
                    columnSorter.Order = SortOrder.Descending;
                } else {
                    columnSorter.Order = SortOrder.Ascending;
                }
            } else {
                // Set the column number that is to be sorted; default to ascending.
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvItems.Sort();
        }

        private void lvItems_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                var item = (Item)lvItems.SelectedItems[0].Tag;
                OwnedItemList_Target inventoryItem = null;

                if (item.isKeyItem) {
                    inventoryItem = save.userData.importantOwendItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
                } else {
                    inventoryItem = save.userData.normalOwnedItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
                }

                int oldCount = inventoryItem == null ? 0 : inventoryItem.count;
                int newCount = GetInt(item.name, oldCount);

                if (oldCount != newCount) {
                    if (inventoryItem == null) {
                        inventoryItem = new OwnedItemList_Target() {
                            contentId = item.contentId,
                            count = newCount,
                        };

                        if (item.isKeyItem) {
                            save.userData.importantOwendItemList.target.Add(inventoryItem);
                        } else {
                            save.userData.normalOwnedItemList.target.Add(inventoryItem);
                            save.userData.normalOwnedItemSortIdList.target.Add(item.contentId);
                        }
                    } else {
                        inventoryItem.count = newCount;
                    }
                }

                UpdateDisplay();
            }
        }

        private void mnuAdd10OfEachItem_Click(object sender, EventArgs e) {
            AddNOfEachItem(10);
        }

        private void mnuAdd99OfEachItem_Click(object sender, EventArgs e) {
            AddNOfEachItem(99);
        }

        private void UpdateDisplay() {
            lvItems.Items.Clear();

            foreach (var item in Items.GetItems(save.GetType()).Where(x => x.name != "None")) {
                var lvi = new ListViewItem();

                OwnedItemList_Target inventoryItem = null;
                if (item.isKeyItem) {
                    inventoryItem = save.userData.importantOwendItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
                } else {
                    inventoryItem = save.userData.normalOwnedItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
                }

                lvi.Tag = item;
                lvi.Text = item.name;
                lvi.SubItems.Add((item.isKeyItem ? "(Key Item) " : "") + item.description);
                lvi.SubItems.Add(item.type);
                lvi.SubItems.Add(inventoryItem == null ? "00" : inventoryItem.count.ToString("d2"));

                lvItems.Items.Add(lvi);
            }
        }
    }
}
