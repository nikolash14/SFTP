namespace SFTPFilePicking
{
    partial class Upload
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuDownload = new System.Windows.Forms.ToolStripLabel();
            this.menuUpload = new System.Windows.Forms.ToolStripLabel();
            this.pnlDownload = new System.Windows.Forms.Panel();
            this.btnFetch = new System.Windows.Forms.Button();
            this.lblSFTPFilePath = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtSFTPFilePath = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.pnlDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDownload,
            this.menuUpload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1318, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuDownload
            // 
            this.menuDownload.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.menuDownload.Name = "menuDownload";
            this.menuDownload.Size = new System.Drawing.Size(78, 25);
            this.menuDownload.Text = "Download";
            this.menuDownload.Click += new System.EventHandler(this.menuDownload_Click);
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
            this.pnlDownload.Controls.Add(this.btnFetch);
            this.pnlDownload.Controls.Add(this.lblSFTPFilePath);
            this.pnlDownload.Controls.Add(this.lblHost);
            this.pnlDownload.Controls.Add(this.txtHost);
            this.pnlDownload.Controls.Add(this.txtSFTPFilePath);
            this.pnlDownload.Controls.Add(this.txtUserName);
            this.pnlDownload.Controls.Add(this.lblUserName);
            this.pnlDownload.Controls.Add(this.lblPort);
            this.pnlDownload.Controls.Add(this.txtPort);
            this.pnlDownload.Location = new System.Drawing.Point(1, 25);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(1316, 642);
            this.pnlDownload.TabIndex = 15;
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
            this.btnFetch.Location = new System.Drawing.Point(18, 162);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(88, 35);
            this.btnFetch.TabIndex = 2;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            // 
            // lblSFTPFilePath
            // 
            this.lblSFTPFilePath.AutoSize = true;
            this.lblSFTPFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFTPFilePath.ForeColor = System.Drawing.Color.Black;
            this.lblSFTPFilePath.Location = new System.Drawing.Point(13, 112);
            this.lblSFTPFilePath.Name = "lblSFTPFilePath";
            this.lblSFTPFilePath.Size = new System.Drawing.Size(159, 25);
            this.lblSFTPFilePath.TabIndex = 0;
            this.lblSFTPFilePath.Text = "SFTP File Path";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.ForeColor = System.Drawing.Color.Black;
            this.lblHost.Location = new System.Drawing.Point(13, 54);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(56, 25);
            this.lblHost.TabIndex = 3;
            this.lblHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(97, 49);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(135, 30);
            this.txtHost.TabIndex = 4;
            // 
            // txtSFTPFilePath
            // 
            this.txtSFTPFilePath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSFTPFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFTPFilePath.Location = new System.Drawing.Point(192, 112);
            this.txtSFTPFilePath.Name = "txtSFTPFilePath";
            this.txtSFTPFilePath.Size = new System.Drawing.Size(500, 30);
            this.txtSFTPFilePath.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(646, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 30);
            this.txtUserName.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(517, 49);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 25);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "UserName";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.Black;
            this.lblPort.Location = new System.Drawing.Point(263, 54);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(51, 25);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(352, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(135, 30);
            this.txtPort.TabIndex = 6;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 692);
            this.Controls.Add(this.pnlDownload);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Upload";
            this.Text = "Upload";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlDownload.ResumeLayout(false);
            this.pnlDownload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel menuDownload;
        private System.Windows.Forms.ToolStripLabel menuUpload;
        private System.Windows.Forms.Panel pnlDownload;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label lblSFTPFilePath;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtSFTPFilePath;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
    }
}