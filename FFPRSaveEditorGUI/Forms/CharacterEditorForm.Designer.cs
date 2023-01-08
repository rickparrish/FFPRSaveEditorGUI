namespace FFPRSaveEditorGUI.Forms {
    partial class CharacterEditorForm {
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
            this.lvCharacters = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chLevel = new System.Windows.Forms.ColumnHeader();
            this.chExperience = new System.Windows.Forms.ColumnHeader();
            this.chMaxHP = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaxAllCharacters = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCharacters
            // 
            this.lvCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chLevel,
            this.chExperience,
            this.chMaxHP});
            this.lvCharacters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCharacters.FullRowSelect = true;
            this.lvCharacters.GridLines = true;
            this.lvCharacters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCharacters.Location = new System.Drawing.Point(0, 24);
            this.lvCharacters.Name = "lvCharacters";
            this.lvCharacters.Size = new System.Drawing.Size(359, 337);
            this.lvCharacters.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvCharacters.TabIndex = 0;
            this.lvCharacters.UseCompatibleStateImageBehavior = false;
            this.lvCharacters.View = System.Windows.Forms.View.Details;
            this.lvCharacters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvCharacters_MouseDoubleClick);
            // 
            // chName
            // 
            this.chName.Tag = "name";
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chLevel
            // 
            this.chLevel.Tag = "addtionalLevel";
            this.chLevel.Text = "Level";
            this.chLevel.Width = 75;
            // 
            // chExperience
            // 
            this.chExperience.Tag = "currentExp";
            this.chExperience.Text = "Experience";
            this.chExperience.Width = 75;
            // 
            // chMaxHP
            // 
            this.chMaxHP.Tag = "addtionalMaxHp";
            this.chMaxHP.Text = "Max HP";
            this.chMaxHP.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaxAllCharacters});
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.charactersToolStripMenuItem.Text = "&Characters";
            // 
            // mnuMaxAllCharacters
            // 
            this.mnuMaxAllCharacters.Name = "mnuMaxAllCharacters";
            this.mnuMaxAllCharacters.Size = new System.Drawing.Size(180, 22);
            this.mnuMaxAllCharacters.Text = "&Max All Characters";
            this.mnuMaxAllCharacters.Click += new System.EventHandler(this.mnuMaxAllCharacters_Click);
            // 
            // CharacterEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 361);
            this.Controls.Add(this.lvCharacters);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvCharacters;
        private ColumnHeader chName;
        private ColumnHeader chExperience;
        private ColumnHeader chMaxHP;
        private ColumnHeader chLevel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem charactersToolStripMenuItem;
        private ToolStripMenuItem mnuMaxAllCharacters;
    }
}