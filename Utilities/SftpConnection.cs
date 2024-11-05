using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.Collections.Generic;
using System.IO;

namespace SFTPFilePicking.Utilities
{
    public static class SftpConnection
    {
        /// <summary>
        /// Get SFTP Connection information to connect the SFTP server
        /// </summary>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="port"></param>
        /// <param name="password"></param>
        /// <param name="publicKeyPath"></param>
        /// <returns></returns>
        public static ConnectionInfo GetSftpConnection(string host, string username, int port, string password, string publicKeyPath)
        {
            return new ConnectionInfo(host, port, username, PrivateKeyObject(username, password, publicKeyPath));
        }

        /// <summary>
        /// Get Private Key object for SFTP login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="publicKeyPath"></param>
        /// <returns></returns>
        private static AuthenticationMethod[] PrivateKeyObject(string username, string password, string publicKeyPath)
        {
            PrivateKeyFile privateKeyFile = new PrivateKeyFile(publicKeyPath);
            return new AuthenticationMethod[]
             {
                    new PasswordAuthenticationMethod(username, password),
                    new PrivateKeyAuthenticationMethod(username, privateKeyFile)
             };
        }

        /// <summary>
        /// Get SFTP Connection information to connect the SFTP server using public key path
        /// </summary>
        /// <param name="sftpSetup"></param>
        /// <returns></returns>
        public static SftpClient GetSftpClient(SftpSetup sftpSetup)
        {
            var connectionInfo = new ConnectionInfo(sftpSetup.HostName, sftpSetup.UserName, PrivateKeyObject(sftpSetup.UserName, sftpSetup.Password, sftpSetup.PublicKeyPath));
            var client = new SftpClient(connectionInfo);
            client.Connect();
            return client;
        }

        /// <summary>
        ///  Get List of files in the SFTP server file path
        /// </summary>
        /// <param name="sftpClient"></param>
        /// <param name="sftpSetup"></param>
        /// <returns></returns>
        public static IEnumerable<SftpFile> ListFiles(SftpClient sftpClient, string serverFilePath)
        {
            return sftpClient.ListDirectory(serverFilePath);
        }

        /// <summary>
        /// Opens an existing file for reading and  Uploads stream into remote file. 
        /// Upload file to the remote sftp server from the client local server
        /// </summary>
        /// <param name="sftpClient"></param>
        /// <param name="localPath"></param>
        /// <param name="serverPath"></param>
        public static void UploadFile(SftpClient sftpClient, string localPath, string serverPath)
        {
            var localFile = File.OpenRead(localPath);
            sftpClient.UploadFile(localFile, serverPath);
        }

        /// <summary>
        /// Creates or overwrites or Opens a file in the specified path and Downloads remote file specified by the path into the stream. 
        /// File to the client local server from the remote sftp server
        /// </summary>
        /// <param name="sftpClient"></param>
        /// <param name="localPath"></param>
        /// <param name="serverPath"></param>
        public static void DownloadFile(SftpClient sftpClient, string localPath, string serverPath, bool isFolderOverride)
        {
            if (isFolderOverride)
            {
                var localFile = File.Create(localPath);
                sftpClient.DownloadFile(serverPath, localFile);
            }
            else
            {
                var localFile = File.OpenWrite(localPath);
                sftpClient.DownloadFile(serverPath, localFile);
            }
        }

        /// <summary>
        /// Opens an existing file or creates a new file for writing in clinet server, 
        /// Opens an existing file for reading in the remote server and Downloads remote file specified by the path into the stream.
        /// File to the client local server from the remote sftp server
        /// </summary>
        /// <param name="sftpClient"></param>
        /// <param name="localPath"></param>
        /// <param name="serverPath"></param>
        /// <param name="fileName"></param>
        public static void DownloadFile(SftpClient sftpClient, string localPath, string serverPath, string fileName)
        {
            string localFullPath = Path.Combine(localPath, fileName);
            FileStream stream = new FileStream(localFullPath, FileMode.CreateNew);
            string serverFullPath = Path.Combine(serverPath, fileName);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(ReadFile(sftpClient, serverFullPath));
            }
            //File.OpenWrite(localPath);
            //Stream fileData = File.OpenRead(localPath + fileName);
            //sftpClient.DownloadFile(serverPath, fileData);
        }

        /// <summary>
        /// Opens a text file, reads all lines of the file with the UTF-8 encoding, and closes
        /// </summary>
        /// <param name="sftpClient"></param>
        /// <param name="serverPath"></param>
        /// <returns></returns>
        public static string ReadFile(SftpClient sftpClient, string serverPath)
        {
            return sftpClient.ReadAllText(serverPath);
        }

        /// <summary>
        /// Deletes remote file specified by path.
        /// </summary>
        /// <param name="sftpClient"></param>
        /// <param name="serverPath"></param>
        /// <param name="fileName"></param>
        public static void DeleteFile(SftpClient sftpClient, string serverPath, string fileName)
        {
            string serverFullPath = Path.Combine(serverPath, fileName);
            sftpClient.DeleteFile(serverFullPath);
        }

    }
}
