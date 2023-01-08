namespace FFPRSaveEditorGUI.Forms {
    partial class SaveGamesForm {
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
            this.cmdLoadAll = new System.Windows.Forms.Button();
            this.lvSaveGames = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cmdLoadAll
            // 
            this.cmdLoadAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdLoadAll.Location = new System.Drawing.Point(0, 313);
            this.cmdLoadAll.Name = "cmdLoadAll";
            this.cmdLoadAll.Size = new System.Drawing.Size(534, 23);
            this.cmdLoadAll.TabIndex = 1;
            this.cmdLoadAll.Text = "&Load All Save Games";
            this.cmdLoadAll.UseVisualStyleBackColor = true;
            this.cmdLoadAll.Click += new System.EventHandler(this.cmdLoadAll_Click);
            // 
            // lvSaveGames
            // 
            this.lvSaveGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSaveGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvSaveGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSaveGames.FullRowSelect = true;
            this.lvSaveGames.GridLines = true;
            this.lvSaveGames.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSaveGames.Location = new System.Drawing.Point(0, 0);
            this.lvSaveGames.MultiSelect = false;
            this.lvSaveGames.Name = "lvSaveGames";
            this.lvSaveGames.Size = new System.Drawing.Size(534, 313);
            this.lvSaveGames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSaveGames.TabIndex = 2;
            this.lvSaveGames.UseCompatibleStateImageBehavior = false;
            this.lvSaveGames.View = System.Windows.Forms.View.Tile;
            this.lvSaveGames.DoubleClick += new System.EventHandler(this.lvSaveGames_DoubleClick);
            // 
            // SaveGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.lvSaveGames);
            this.Controls.Add(this.cmdLoadAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveGamesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Games";
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdLoadAll;
        private ListView lvSaveGames;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}