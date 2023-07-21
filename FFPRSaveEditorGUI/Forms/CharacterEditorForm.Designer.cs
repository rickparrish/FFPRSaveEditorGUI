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
            lvCharacters = new ListView();
            chName = new ColumnHeader();
            chLevel = new ColumnHeader();
            chExperience = new ColumnHeader();
            chMaxHP = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            charactersToolStripMenuItem = new ToolStripMenuItem();
            mnuMaxCharacters = new ToolStripMenuItem();
            mnuFF2 = new ToolStripMenuItem();
            mnuFF2MaxWeapons = new ToolStripMenuItem();
            mnuFF2MaxMagic = new ToolStripMenuItem();
            mnuFF3 = new ToolStripMenuItem();
            mnuFF3MaxJobs = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvCharacters
            // 
            lvCharacters.Columns.AddRange(new ColumnHeader[] { chName, chLevel, chExperience, chMaxHP });
            lvCharacters.Cursor = Cursors.Hand;
            lvCharacters.Dock = DockStyle.Fill;
            lvCharacters.FullRowSelect = true;
            lvCharacters.GridLines = true;
            lvCharacters.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvCharacters.Location = new Point(0, 24);
            lvCharacters.Name = "lvCharacters";
            lvCharacters.Size = new Size(359, 337);
            lvCharacters.Sorting = SortOrder.Ascending;
            lvCharacters.TabIndex = 0;
            lvCharacters.UseCompatibleStateImageBehavior = false;
            lvCharacters.View = View.Details;
            lvCharacters.MouseDoubleClick += lvCharacters_MouseDoubleClick;
            // 
            // chName
            // 
            chName.Tag = "name";
            chName.Text = "Name";
            chName.Width = 100;
            // 
            // chLevel
            // 
            chLevel.Tag = "addtionalLevel";
            chLevel.Text = "Level";
            chLevel.Width = 75;
            // 
            // chExperience
            // 
            chExperience.Tag = "currentExp";
            chExperience.Text = "Experience";
            chExperience.Width = 75;
            // 
            // chMaxHP
            // 
            chMaxHP.Tag = "addtionalMaxHp";
            chMaxHP.Text = "Max HP";
            chMaxHP.Width = 75;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { charactersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(359, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // charactersToolStripMenuItem
            // 
            charactersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuMaxCharacters, mnuFF2, mnuFF3 });
            charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            charactersToolStripMenuItem.Size = new Size(95, 20);
            charactersToolStripMenuItem.Text = "&Quick Options";
            // 
            // mnuMaxCharacters
            // 
            mnuMaxCharacters.Name = "mnuMaxCharacters";
            mnuMaxCharacters.Size = new Size(180, 22);
            mnuMaxCharacters.Text = "&Max Character Stats";
            mnuMaxCharacters.Click += mnuMaxCharacters_Click;
            // 
            // mnuFF2
            // 
            mnuFF2.DropDownItems.AddRange(new ToolStripItem[] { mnuFF2MaxMagic, mnuFF2MaxWeapons });
            mnuFF2.Name = "mnuFF2";
            mnuFF2.Size = new Size(180, 22);
            mnuFF2.Text = "FF&2";
            mnuFF2.Visible = false;
            // 
            // mnuFF2MaxWeapons
            // 
            mnuFF2MaxWeapons.Name = "mnuFF2MaxWeapons";
            mnuFF2MaxWeapons.Size = new Size(280, 22);
            mnuFF2MaxWeapons.Text = "Max Selected Character &Weapon Levels";
            mnuFF2MaxWeapons.Click += mnuFF2MaxWeapons_Click;
            // 
            // mnuFF2MaxMagic
            // 
            mnuFF2MaxMagic.Name = "mnuFF2MaxMagic";
            mnuFF2MaxMagic.Size = new Size(280, 22);
            mnuFF2MaxMagic.Text = "Max Selected Character &Magic Levels";
            mnuFF2MaxMagic.Click += mnuFF2MaxMagic_Click;
            // 
            // mnuFF3
            // 
            mnuFF3.DropDownItems.AddRange(new ToolStripItem[] { mnuFF3MaxJobs });
            mnuFF3.Name = "mnuFF3";
            mnuFF3.Size = new Size(180, 22);
            mnuFF3.Text = "FF&3";
            // 
            // mnuFF3MaxJobs
            // 
            mnuFF3MaxJobs.Name = "mnuFF3MaxJobs";
            mnuFF3MaxJobs.Size = new Size(224, 22);
            mnuFF3MaxJobs.Text = "Max Selected Character &Jobs";
            mnuFF3MaxJobs.Click += mnuFF3MaxJobs_Click;
            // 
            // CharacterEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 361);
            Controls.Add(lvCharacters);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CharacterEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Character Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvCharacters;
        private ColumnHeader chName;
        private ColumnHeader chExperience;
        private ColumnHeader chMaxHP;
        private ColumnHeader chLevel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem charactersToolStripMenuItem;
        private ToolStripMenuItem mnuMaxCharacters;
        private ToolStripMenuItem mnuFF2;
        private ToolStripMenuItem mnuFF2MaxWeapons;
        private ToolStripMenuItem mnuFF2MaxMagic;
        private ToolStripMenuItem mnuFF3;
        private ToolStripMenuItem mnuFF3MaxJobs;
    }
}