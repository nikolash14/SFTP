namespace SFTPFilePicking
{
    partial class SFTP
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
            this.components = new System.ComponentModel.Container();
            this.lblSFTPFilePath = new System.Windows.Forms.Label();
            this.txtSFTPFilePath = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuDownload = new System.Windows.Forms.ToolStripLabel();
            this.menuUpload = new System.Windows.Forms.ToolStripLabel();
            this.pnlDownload = new System.Windows.Forms.Panel();
            this.pnlMessage = new System.Windows.Forms.Panel();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.lblFetchedFiles = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlDownload.SuspendLayout();
            this.pnlMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSFTPFilePath
            // 
            this.lblSFTPFilePath.AutoSize = true;
            this.lblSFTPFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFTPFilePath.ForeColor = System.Drawing.Color.Black;
            this.lblSFTPFilePath.Location = new System.Drawing.Point(16, 81);
            this.lblSFTPFilePath.Name = "lblSFTPFilePath";
            this.lblSFTPFilePath.Size = new System.Drawing.Size(263, 25);
            this.lblSFTPFilePath.TabIndex = 0;
            this.lblSFTPFilePath.Text = "SFTP Pubic Key File Path";
            // 
            // txtSFTPFilePath
            // 
            this.txtSFTPFilePath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSFTPFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFTPFilePath.Location = new System.Drawing.Point(308, 81);
            this.txtSFTPFilePath.Name = "txtSFTPFilePath";
            this.txtSFTPFilePath.Size = new System.Drawing.Size(500, 30);
            this.txtSFTPFilePath.TabIndex = 1;
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFetch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFetch.FlatAppearance.BorderSize = 2;
            this.btnFetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFetch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFetch.Location = new System.Drawing.Point(18, 194);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(88, 35);
            this.btnFetch.TabIndex = 2;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.Color.Black;
            this.lblHost.Location = new System.Drawing.Point(16, 26);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(56, 25);
            this.lblHost.TabIndex = 3;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(92, 23);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(135, 30);
            this.txtHost.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.Black;
            this.lblPort.Location = new System.Drawing.Point(260, 28);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(51, 25);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(350, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(135, 30);
            this.txtPort.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(647, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 30);
            this.txtUserName.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(513, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 25);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "UserName";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 58);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1328, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDownload,
            this.menuUpload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1328, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuDownload
            // 
            this.menuDownload.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.menuDownload.Name = "menuDownload";
            this.menuDownload.Size = new System.Drawing.Size(78, 25);
            this.menuDownload.Text = "Download";
            // 
            // menuUpload
            // 
            this.menuUpload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUpload.Name = "menuUpload";
            this.menuUpload.Size = new System.Drawing.Size(58, 22);
            this.menuUpload.Text = "Upload";
            this.menuUpload.Click += new System.EventHandler(this.menuUpload_Click);
            // 
            // pnlDownload
            // 
            this.pnlDownload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlDownload.Controls.Add(this.txtLocalPath);
            this.pnlDownload.Controls.Add(this.lblLocal);
            this.pnlDownload.Controls.Add(this.txtServerPath);
            this.pnlDownload.Controls.Add(this.lblServer);
            this.pnlDownload.Controls.Add(this.pnlMessage);
            this.pnlDownload.Controls.Add(this.lblFetchedFiles);
            this.pnlDownload.Controls.Add(this.btnFetch);
            this.pnlDownload.Controls.Add(this.lblSFTPFilePath);
            this.pnlDownload.Controls.Add(this.lblHost);
            this.pnlDownload.Controls.Add(this.txtHost);
            this.pnlDownload.Controls.Add(this.txtSFTPFilePath);
            this.pnlDownload.Controls.Add(this.txtUserName);
            this.pnlDownload.Controls.Add(this.lblUserName);
            this.pnlDownload.Controls.Add(this.lblPort);
            this.pnlDownload.Controls.Add(this.txtPort);
            this.pnlDownload.Location = new System.Drawing.Point(0, 28);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(1316, 642);
            this.pnlDownload.TabIndex = 14;
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMessage.Controls.Add(this.rtxtMessage);
            this.pnlMessage.Location = new System.Drawing.Point(18, 283);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(1281, 340);
            this.pnlMessage.TabIndex = 11;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Enabled = false;
            this.rtxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessage.Location = new System.Drawing.Point(3, 3);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(1275, 334);
            this.rtxtMessage.TabIndex = 0;
            this.rtxtMessage.Text = "";
            // 
            // lblFetchedFiles
            // 
            this.lblFetchedFiles.AutoSize = true;
            this.lblFetchedFiles.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetchedFiles.Location = new System.Drawing.Point(12, 248);
            this.lblFetchedFiles.Name = "lblFetchedFiles";
            this.lblFetchedFiles.Size = new System.Drawing.Size(152, 22);
            this.lblFetchedFiles.TabIndex = 10;
            this.lblFetchedFiles.Text = "Downloaded Files";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.Color.Black;
            this.lblServer.Location = new System.Drawing.Point(16, 132);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(120, 25);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "ServerPath";
            // 
            // txtServerPath
            // 
            this.txtServerPath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtServerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerPath.Location = new System.Drawing.Point(144, 127);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(282, 30);
            this.txtServerPath.TabIndex = 13;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.Black;
            this.lblLocal.Location = new System.Drawing.Point(476, 132);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(108, 25);
            this.lblLocal.TabIndex = 14;
            this.lblLocal.Text = "LocalPath";
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLocalPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalPath.Location = new System.Drawing.Point(605, 129);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(282, 30);
            this.txtLocalPath.TabIndex = 15;
            // 
            // SFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1328, 707);
            this.Controls.Add(this.pnlDownload);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "SFTP";
            this.Text = "FilePicking";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlDownload.ResumeLayout(false);
            this.pnlDownload.PerformLayout();
            this.pnlMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSFTPFilePath;
        private System.Windows.Forms.TextBox txtSFTPFilePath;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel menuDownload;
        private System.Windows.Forms.ToolStripLabel menuUpload;
        private System.Windows.Forms.Panel pnlDownload;
        private System.Windows.Forms.Label lblFetchedFiles;
        private System.Windows.Forms.Panel pnlMessage;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.TextBox txtLocalPath;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.Label lblServer;
    }
}

