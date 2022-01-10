namespace File_Folder_Selector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.toAddTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.alterBtn = new System.Windows.Forms.Button();
            this.tutorialLabel = new System.Windows.Forms.Label();
            this.zipFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.exampleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainListBox
            // 
            this.mainListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainListBox.ForeColor = System.Drawing.Color.White;
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 16;
            this.mainListBox.Location = new System.Drawing.Point(12, 12);
            this.mainListBox.MultiColumn = true;
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(385, 212);
            this.mainListBox.Sorted = true;
            this.mainListBox.TabIndex = 0;
            this.mainListBox.SelectedIndexChanged += new System.EventHandler(this.mainListBox_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(322, 335);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(93, 335);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // toAddTextBox
            // 
            this.toAddTextBox.Location = new System.Drawing.Point(238, 259);
            this.toAddTextBox.Name = "toAddTextBox";
            this.toAddTextBox.Size = new System.Drawing.Size(159, 20);
            this.toAddTextBox.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(322, 285);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.Location = new System.Drawing.Point(238, 285);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 6;
            this.browseBtn.Text = "Browse File";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // alterBtn
            // 
            this.alterBtn.Enabled = false;
            this.alterBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterBtn.Location = new System.Drawing.Point(12, 335);
            this.alterBtn.Name = "alterBtn";
            this.alterBtn.Size = new System.Drawing.Size(75, 23);
            this.alterBtn.TabIndex = 8;
            this.alterBtn.Text = "Alter";
            this.alterBtn.UseVisualStyleBackColor = true;
            this.alterBtn.Click += new System.EventHandler(this.alterBtn_Click);
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.ForeColor = System.Drawing.Color.White;
            this.tutorialLabel.Location = new System.Drawing.Point(12, 262);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(181, 43);
            this.tutorialLabel.TabIndex = 9;
            this.tutorialLabel.Text = "You may add Files and Folders  which you can whitelist or blacklist from being in" +
    "cluded in the zip file";
            // 
            // zipFolderCheckBox
            // 
            this.zipFolderCheckBox.AutoSize = true;
            this.zipFolderCheckBox.ForeColor = System.Drawing.Color.White;
            this.zipFolderCheckBox.Location = new System.Drawing.Point(15, 308);
            this.zipFolderCheckBox.Name = "zipFolderCheckBox";
            this.zipFolderCheckBox.Size = new System.Drawing.Size(188, 17);
            this.zipFolderCheckBox.TabIndex = 11;
            this.zipFolderCheckBox.Text = "Create Zip Folder (Recommended)";
            this.zipFolderCheckBox.UseVisualStyleBackColor = true;
            this.zipFolderCheckBox.CheckedChanged += new System.EventHandler(this.zipFolderCheckBox_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(241, 335);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // exampleLbl
            // 
            this.exampleLbl.AutoSize = true;
            this.exampleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exampleLbl.ForeColor = System.Drawing.Color.White;
            this.exampleLbl.Location = new System.Drawing.Point(238, 241);
            this.exampleLbl.Name = "exampleLbl";
            this.exampleLbl.Size = new System.Drawing.Size(155, 16);
            this.exampleLbl.TabIndex = 13;
            this.exampleLbl.Text = "ie: project.csproj, *.txt, bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(409, 366);
            this.Controls.Add(this.exampleLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.zipFolderCheckBox);
            this.Controls.Add(this.tutorialLabel);
            this.Controls.Add(this.alterBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.toAddTextBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.mainListBox);
            this.MaximumSize = new System.Drawing.Size(425, 405);
            this.MinimumSize = new System.Drawing.Size(425, 405);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox toAddTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button alterBtn;
        private System.Windows.Forms.Label tutorialLabel;
        private System.Windows.Forms.CheckBox zipFolderCheckBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label exampleLbl;
    }
}

