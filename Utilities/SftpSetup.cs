namespace SFTPFilePicking.Utilities
{
    public class SftpSetup
    {
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ServerDirectory { get; set; }
        public string HostName { get; set; }
        public string LocalDirectory { get; set; }
        public string PublicKeyPath { get; set; }
    }
}
