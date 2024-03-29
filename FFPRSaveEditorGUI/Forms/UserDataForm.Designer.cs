﻿namespace FFPRSaveEditorGUI.Forms {
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
            this.cmdItemEditor = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.lblSaveId = new System.Windows.Forms.Label();
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
            this.cmdCharacterEditor.Location = new System.Drawing.Point(338, 73);
            this.cmdCharacterEditor.Name = "cmdCharacterEditor";
            this.cmdCharacterEditor.Size = new System.Drawing.Size(140, 23);
            this.cmdCharacterEditor.TabIndex = 4;
            this.cmdCharacterEditor.Text = "&Character Editor";
            this.cmdCharacterEditor.UseVisualStyleBackColor = true;
            this.cmdCharacterEditor.Click += new System.EventHandler(this.cmdCharacterEditor_Click);
            // 
            // cmdItemEditor
            // 
            this.cmdItemEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdItemEditor.Location = new System.Drawing.Point(338, 102);
            this.cmdItemEditor.Name = "cmdItemEditor";
            this.cmdItemEditor.Size = new System.Drawing.Size(140, 23);
            this.cmdItemEditor.TabIndex = 9;
            this.cmdItemEditor.Text = "&Item Editor";
            this.cmdItemEditor.UseVisualStyleBackColor = true;
            this.cmdItemEditor.Click += new System.EventHandler(this.cmdItemEditor_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(338, 140);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(140, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayTime.Location = new System.Drawing.Point(12, 171);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(85, 21);
            this.lblPlayTime.TabIndex = 12;
            this.lblPlayTime.Text = "Play Time";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeStamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTimeStamp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeStamp.Location = new System.Drawing.Point(12, 150);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(101, 21);
            this.lblTimeStamp.TabIndex = 14;
            this.lblTimeStamp.Text = "Time Stamp";
            // 
            // lblSaveId
            // 
            this.lblSaveId.AutoSize = true;
            this.lblSaveId.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaveId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaveId.Location = new System.Drawing.Point(12, 129);
            this.lblSaveId.Name = "lblSaveId";
            this.lblSaveId.Size = new System.Drawing.Size(67, 21);
            this.lblSaveId.TabIndex = 16;
            this.lblSaveId.Text = "Save ID";
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 200);
            this.Controls.Add(this.lblSaveId);
            this.Controls.Add(this.lblTimeStamp);
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdItemEditor);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDataForm_FormClosing);
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
        private Button cmdItemEditor;
        private Button cmdCancel;
        private Label lblPlayTime;
        private Label lblTimeStamp;
        private Label lblSaveId;
    }
}