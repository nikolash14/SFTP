using SFTPFilePicking.Utilities;
using System;
using System.Windows.Forms;
using System.Linq;

namespace SFTPFilePicking
{
    public partial class SFTP : Form
    {
        public SFTP()
        {
            InitializeComponent();
        }
        private void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                SftpSetup sftpSetup = AppSettings.GetSftpSetup();
                CheckFromSource(sftpSetup);
                using (var sftp = SftpConnection.GetSftpClient(sftpSetup))
                {
                    //if(sftp.IsConnected)
                    //{
                    //    sftp.ChangeDirectory(sftpSetup.ServerDirectory);
                    //    var fil = sftp.ListDirectory(sftpSetup.ServerDirectory).ToList();
                    //    sftp.Disconnect();
                    //}
                    //else
                    //{
                    //    this.rtxtMessage.Text = "Can't connect to Server.";
                    //}

                    var files = SftpConnection.ListFiles(sftp, sftpSetup.ServerDirectory);
                    foreach (var fileName in from file in files where !file.Name.StartsWith(".") select file.Name)
                    {
                        SftpConnection.DownloadFile(sftp, sftpSetup.LocalDirectory, sftpSetup.ServerDirectory, fileName);
                        SftpConnection.DeleteFile(sftp, sftpSetup.ServerDirectory, fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                this.rtxtMessage.Text = ex.Message;
            }
        }

        private void CheckFromSource(SftpSetup sftpSetup)
        {
            if (!string.IsNullOrEmpty(this.txtHost.Text)){
                sftpSetup.HostName = this.txtHost.Text.Trim();
            }
            if (!string.IsNullOrEmpty(this.txtPort.Text))
            {
                sftpSetup.Port = Convert.ToInt32(this.txtPort.Text.Trim());
            }
            if (!string.IsNullOrEmpty(this.txtSFTPFilePath.Text))
            {
                sftpSetup.PublicKeyPath = this.txtSFTPFilePath.Text.Trim();
            }
            if (!string.IsNullOrEmpty(this.txtUserName.Text))
            {
                sftpSetup.UserName = this.txtUserName.Text.Trim();
            }
            if (!string.IsNullOrEmpty(this.txtServerPath.Text))
            {
                sftpSetup.ServerDirectory = this.txtServerPath.Text.Trim();
            }
            if (!string.IsNullOrEmpty(this.txtLocalPath.Text))
            {
                sftpSetup.LocalDirectory = this.txtLocalPath.Text.Trim();
            }
        }
        private void menuDownload_Click(object sender, EventArgs e)
        {
            this.Hide();
            SFTP sFTP = new SFTP();
            sFTP.Show();
        }

        private void menuUpload_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload upload = new Upload();
            upload.Show();
        }
    }
}
