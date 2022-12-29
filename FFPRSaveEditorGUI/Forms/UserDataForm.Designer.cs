namespace FFPRSaveEditorGUI.Forms {
    partial class UserDataForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGil = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.cmdCharacterEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gil/Gold:";
            // 
            // lblGil
            // 
            this.lblGil.AutoSize = true;
            this.lblGil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGil.Location = new System.Drawing.Point(398, 12);
            this.lblGil.Name = "lblGil";
            this.lblGil.Size = new System.Drawing.Size(13, 15);
            this.lblGil.TabIndex = 1;
            this.lblGil.Text = "0";
            this.lblGil.Click += new System.EventHandler(this.lblGil_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdSave.Location = new System.Drawing.Point(338, 169);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(140, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // pbScreen
            // 
            this.pbScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbScreen.Location = new System.Drawing.Point(12, 12);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(320, 180);
            this.pbScreen.TabIndex = 3;
            this.pbScreen.TabStop = false;
            // 
            // cmdCharacterEditor
            // 
            this.cmdCharacterEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCharacterEditor.Location = new System.Drawing.Point(338, 81);
            this.cmdCharacterEditor.Name = "cmdCharacterEditor";
            this.cmdCharacterEditor.Size = new System.Drawing.Size(140, 23);
            this.cmdCharacterEditor.TabIndex = 4;
            this.cmdCharacterEditor.Text = "&CharacterEditor";
            this.cmdCharacterEditor.UseVisualStyleBackColor = true;
            this.cmdCharacterEditor.Click += new System.EventHandler(this.cmdCharacterEditor_Click);
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 200);
            this.Controls.Add(this.cmdCharacterEditor);
            this.Controls.Add(this.pbScreen);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblGil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblGil;
        private Button cmdSave;
        private PictureBox pbScreen;
        private Button cmdCharacterEditor;
    }
}