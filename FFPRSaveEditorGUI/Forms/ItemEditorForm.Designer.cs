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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvItems = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chCount = new System.Windows.Forms.ColumnHeader();
            this.txtContentId = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.cmdAddItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAddItem);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.txtContentId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Item";
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chCount});
            this.lvItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvItems.Location = new System.Drawing.Point(0, 0);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(284, 305);
            this.lvItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvItems.TabIndex = 4;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            this.lvItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvItems_MouseDoubleClick);
            // 
            // chName
            // 
            this.chName.Tag = "";
            this.chName.Text = "Name";
            this.chName.Width = 200;
            // 
            // chCount
            // 
            this.chCount.Tag = "";
            this.chCount.Text = "Count";
            this.chCount.Width = 50;
            // 
            // txtContentId
            // 
            this.txtContentId.Location = new System.Drawing.Point(12, 22);
            this.txtContentId.Name = "txtContentId";
            this.txtContentId.Size = new System.Drawing.Size(169, 23);
            this.txtContentId.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(187, 22);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(32, 23);
            this.txtCount.TabIndex = 1;
            this.txtCount.Text = "1";
            // 
            // cmdAddItem
            // 
            this.cmdAddItem.Location = new System.Drawing.Point(225, 21);
            this.cmdAddItem.Name = "cmdAddItem";
            this.cmdAddItem.Size = new System.Drawing.Size(47, 23);
            this.cmdAddItem.TabIndex = 2;
            this.cmdAddItem.Text = "&Add";
            this.cmdAddItem.UseVisualStyleBackColor = true;
            this.cmdAddItem.Click += new System.EventHandler(this.cmdAddItem_Click);
            // 
            // ItemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lvItems;
        private ColumnHeader chName;
        private ColumnHeader chCount;
        private Button cmdAddItem;
        private TextBox txtCount;
        private TextBox txtContentId;
    }
}