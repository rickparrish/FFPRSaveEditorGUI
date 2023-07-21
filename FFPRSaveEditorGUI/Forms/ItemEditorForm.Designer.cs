namespace FFPRSaveEditorGUI.Forms {
    partial class ItemEditorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lvItems = new ListView();
            chName = new ColumnHeader();
            chDescription = new ColumnHeader();
            chType = new ColumnHeader();
            chCount = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            mnuAdd99OfEachItem = new ToolStripMenuItem();
            mnuAdd10OfEachItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvItems
            // 
            lvItems.Columns.AddRange(new ColumnHeader[] { chName, chDescription, chType, chCount });
            lvItems.Cursor = Cursors.Hand;
            lvItems.Dock = DockStyle.Fill;
            lvItems.FullRowSelect = true;
            lvItems.GridLines = true;
            lvItems.Location = new Point(0, 24);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(984, 537);
            lvItems.Sorting = SortOrder.Ascending;
            lvItems.TabIndex = 4;
            lvItems.UseCompatibleStateImageBehavior = false;
            lvItems.View = View.Details;
            lvItems.ColumnClick += lvItems_ColumnClick;
            lvItems.MouseDoubleClick += lvItems_MouseDoubleClick;
            // 
            // chName
            // 
            chName.Tag = "";
            chName.Text = "Name";
            chName.Width = 125;
            // 
            // chDescription
            // 
            chDescription.Text = "Description";
            chDescription.Width = 625;
            // 
            // chType
            // 
            chType.Text = "Type";
            chType.Width = 150;
            // 
            // chCount
            // 
            chCount.Tag = "";
            chCount.Text = "Count";
            chCount.Width = 50;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd10OfEachItem, mnuAdd99OfEachItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(48, 20);
            itemsToolStripMenuItem.Text = "&Items";
            // 
            // mnuAdd99OfEachItem
            // 
            mnuAdd99OfEachItem.Name = "mnuAdd99OfEachItem";
            mnuAdd99OfEachItem.Size = new Size(182, 22);
            mnuAdd99OfEachItem.Text = "Add &99 Of Each Item";
            mnuAdd99OfEachItem.Click += mnuAdd99OfEachItem_Click;
            // 
            // mnuAdd10OfEachItem
            // 
            mnuAdd10OfEachItem.Name = "mnuAdd10OfEachItem";
            mnuAdd10OfEachItem.Size = new Size(182, 22);
            mnuAdd10OfEachItem.Text = "Add &10 Of Each Item";
            mnuAdd10OfEachItem.Click += mnuAdd10OfEachItem_Click;
            // 
            // ItemEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(lvItems);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lvItems;
        private ColumnHeader chName;
        private ColumnHeader chCount;
        private ColumnHeader chDescription;
        private ColumnHeader chType;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem mnuAdd99OfEachItem;
        private ToolStripMenuItem mnuAdd10OfEachItem;
    }
}