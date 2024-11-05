using System;
namespace SFTPFilePicking.Utilities
{
    public static class AppSettings
    {
        public static SftpSetup GetSftpSetup()
        {
            return new SftpSetup
            {
                Port = 22,
                UserName = "sftpuser",
                ServerDirectory = "\\",
                HostName = "192.168.0.61",
                Password = "sftp@1234",
                LocalDirectory = @"D:SFTP",
                PublicKeyPath = @"D:Download"
            };
        }

    }

}
