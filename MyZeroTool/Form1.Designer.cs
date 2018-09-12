namespace MyZeroTool
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbCN = new System.Windows.Forms.TextBox();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cbAutoScroll = new System.Windows.Forms.CheckBox();
            this.cbRenameDirectories = new System.Windows.Forms.CheckBox();
            this.cbRenameFiles = new System.Windows.Forms.CheckBox();
            this.cbUpdateFileContents = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(12, 26);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(446, 20);
            this.tbPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(464, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbCN
            // 
            this.tbCN.Location = new System.Drawing.Point(163, 90);
            this.tbCN.Name = "tbCN";
            this.tbCN.Size = new System.Drawing.Size(163, 20);
            this.tbCN.TabIndex = 2;
            // 
            // tbPN
            // 
            this.tbPN.Location = new System.Drawing.Point(163, 133);
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(163, 20);
            this.tbPN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Root Path to Template Files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Company Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project Name:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(332, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 66);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStartClick);
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(15, 169);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(524, 173);
            this.lbLog.TabIndex = 8;
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLog.Location = new System.Drawing.Point(459, 130);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(80, 23);
            this.btnSaveLog.TabIndex = 9;
            this.btnSaveLog.Text = "Save Log...";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Log files|*.log";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(15, 130);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(119, 23);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Other Settings...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cbAutoScroll
            // 
            this.cbAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoScroll.AutoSize = true;
            this.cbAutoScroll.Checked = true;
            this.cbAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoScroll.Location = new System.Drawing.Point(459, 107);
            this.cbAutoScroll.Name = "cbAutoScroll";
            this.cbAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.cbAutoScroll.TabIndex = 11;
            this.cbAutoScroll.Text = "Auto Scroll";
            this.cbAutoScroll.UseVisualStyleBackColor = true;
            // 
            // cbRenameDirectories
            // 
            this.cbRenameDirectories.AutoSize = true;
            this.cbRenameDirectories.Checked = true;
            this.cbRenameDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRenameDirectories.Location = new System.Drawing.Point(15, 59);
            this.cbRenameDirectories.Name = "cbRenameDirectories";
            this.cbRenameDirectories.Size = new System.Drawing.Size(119, 17);
            this.cbRenameDirectories.TabIndex = 12;
            this.cbRenameDirectories.Text = "Rename Directories";
            this.cbRenameDirectories.UseVisualStyleBackColor = true;
            // 
            // cbRenameFiles
            // 
            this.cbRenameFiles.AutoSize = true;
            this.cbRenameFiles.Checked = true;
            this.cbRenameFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRenameFiles.Location = new System.Drawing.Point(15, 82);
            this.cbRenameFiles.Name = "cbRenameFiles";
            this.cbRenameFiles.Size = new System.Drawing.Size(90, 17);
            this.cbRenameFiles.TabIndex = 13;
            this.cbRenameFiles.Text = "Rename Files";
            this.cbRenameFiles.UseVisualStyleBackColor = true;
            // 
            // cbUpdateFileContents
            // 
            this.cbUpdateFileContents.AutoSize = true;
            this.cbUpdateFileContents.Checked = true;
            this.cbUpdateFileContents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpdateFileContents.Location = new System.Drawing.Point(15, 105);
            this.cbUpdateFileContents.Name = "cbUpdateFileContents";
            this.cbUpdateFileContents.Size = new System.Drawing.Size(125, 17);
            this.cbUpdateFileContents.TabIndex = 14;
            this.cbUpdateFileContents.Text = "Update File Contents";
            this.cbUpdateFileContents.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 354);
            this.Controls.Add(this.cbUpdateFileContents);
            this.Controls.Add(this.cbRenameFiles);
            this.Controls.Add(this.cbRenameDirectories);
            this.Controls.Add(this.cbAutoScroll);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPN);
            this.Controls.Add(this.tbCN);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Zero Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbCN;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.CheckBox cbAutoScroll;
        private System.Windows.Forms.CheckBox cbRenameDirectories;
        private System.Windows.Forms.CheckBox cbRenameFiles;
        private System.Windows.Forms.CheckBox cbUpdateFileContents;
    }
}

