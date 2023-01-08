﻿using FFPRSaveEditor.Common.Models;
using System.Data;

namespace FFPRSaveEditorGUI.Forms {
    public partial class ItemEditorForm : Form {
        private ListViewColumnSorter columnSorter;
        private BaseSaveGame save;
        private UserData userData;

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
            this.userData = ((dynamic)save).userData;

            UpdateDisplay();

            columnSorter.Order = SortOrder.Ascending;
            columnSorter.SortColumn = 0;
            this.lvItems.Sort();
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
                    inventoryItem = userData.importantOwendItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
                } else {
                    inventoryItem = userData.normalOwnedItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
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
                            userData.importantOwendItemList.target.Add(inventoryItem);
                        } else {
                            userData.normalOwnedItemList.target.Add(inventoryItem);
                            userData.normalOwnedItemSortIdList.target.Add(item.contentId);
                        }
                    } else {
                        inventoryItem.count = newCount;
                    }
                }

                UpdateDisplay();
            }
        }

        private void mnuAdd99OfEachItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to give yourself 99 of each item?", "Confirm Add 99", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            foreach (var item in NormalItems.GetItems(save.GetType()).Where(x => x.name != "None")) {
                var lvi = new ListViewItem();

                OwnedItemList_Target inventoryItem = null;
                if (!item.isKeyItem) {
                    inventoryItem = userData.normalOwnedItemList.target.SingleOrDefault(x => x.contentId == item.contentId);

                    if (inventoryItem == null) {
                        inventoryItem = new OwnedItemList_Target() {
                            contentId = item.contentId,
                            count = 99,
                        };
                        userData.normalOwnedItemList.target.Add(inventoryItem);
                        userData.normalOwnedItemSortIdList.target.Add(item.contentId);
                    } else {
                        inventoryItem.count = 99;
                    }
                }
            }

            UpdateDisplay();
        }

        private void UpdateDisplay() {
            lvItems.Items.Clear();

            foreach (var item in NormalItems.GetItems(save.GetType()).Where(x => x.name != "None")) {
                var lvi = new ListViewItem();

                OwnedItemList_Target inventoryItem = null;
                if (item.isKeyItem) {
                    inventoryItem = userData.importantOwendItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
                } else {
                    inventoryItem = userData.normalOwnedItemList.target.SingleOrDefault(x => x.contentId == item.contentId);
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
