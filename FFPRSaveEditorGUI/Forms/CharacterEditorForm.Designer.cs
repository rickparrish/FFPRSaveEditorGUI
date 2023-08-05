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
            mnuMaxCharacterStats = new ToolStripMenuItem();
            mnuMaxJobLevels = new ToolStripMenuItem();
            mnuMaxMagicLevels = new ToolStripMenuItem();
            mnuMaxWeaponLevels = new ToolStripMenuItem();
            mnuAddAllMagic = new ToolStripMenuItem();
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
            chLevel.Tag = "Level";
            chLevel.Text = "Level";
            chLevel.Width = 75;
            // 
            // chExperience
            // 
            chExperience.Tag = "Experience";
            chExperience.Text = "Experience";
            chExperience.Width = 75;
            // 
            // chMaxHP
            // 
            chMaxHP.Tag = "HitPointsMax";
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
            charactersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAddAllMagic, mnuMaxCharacterStats, mnuMaxJobLevels, mnuMaxMagicLevels, mnuMaxWeaponLevels });
            charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            charactersToolStripMenuItem.Size = new Size(95, 20);
            charactersToolStripMenuItem.Text = "&Quick Options";
            // 
            // mnuMaxCharacterStats
            // 
            mnuMaxCharacterStats.Name = "mnuMaxCharacterStats";
            mnuMaxCharacterStats.Size = new Size(180, 22);
            mnuMaxCharacterStats.Text = "Max &Character Stats";
            mnuMaxCharacterStats.Click += mnuMaxCharacterStats_Click;
            // 
            // mnuMaxJobLevels
            // 
            mnuMaxJobLevels.Name = "mnuMaxJobLevels";
            mnuMaxJobLevels.Size = new Size(180, 22);
            mnuMaxJobLevels.Text = "Max &Job Levels";
            mnuMaxJobLevels.Click += mnuMaxJobLevels_Click;
            // 
            // mnuMaxMagicLevels
            // 
            mnuMaxMagicLevels.Name = "mnuMaxMagicLevels";
            mnuMaxMagicLevels.Size = new Size(180, 22);
            mnuMaxMagicLevels.Text = "Max &Magic Levels";
            mnuMaxMagicLevels.Click += mnuMaxMagicLevels_Click;
            // 
            // mnuMaxWeaponLevels
            // 
            mnuMaxWeaponLevels.Name = "mnuMaxWeaponLevels";
            mnuMaxWeaponLevels.Size = new Size(180, 22);
            mnuMaxWeaponLevels.Text = "Max &Weapon Levels";
            mnuMaxWeaponLevels.Click += mnuMaxWeaponLevels_Click;
            // 
            // mnuAddAllMagic
            // 
            mnuAddAllMagic.Name = "mnuAddAllMagic";
            mnuAddAllMagic.Size = new Size(180, 22);
            mnuAddAllMagic.Text = "Add All Magic";
            mnuAddAllMagic.Click += mnuAddAllMagic_Click;
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
        private ToolStripMenuItem mnuMaxCharacterStats;
        private ToolStripMenuItem mnuMaxJobLevels;
        private ToolStripMenuItem mnuMaxMagicLevels;
        private ToolStripMenuItem mnuMaxWeaponLevels;
        private ToolStripMenuItem mnuAddAllMagic;
    }
}