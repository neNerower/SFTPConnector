using System;
using System.Security.Cryptography;
using System.Text;

namespace SFTPConnectorModule
{
    public interface ILogInController
    {
        bool CheckPassword(string password);
        void SetNewPassword(string newPassword);
    }
    public class LogInController : ILogInController
    {
        public bool CheckPassword(string password)
        {
            //HashProgrammPassword takes from Settings.HashProgrammPassword
            return Settings.GetHashProgrammPassword() == Hash(password);
        }

        private string Hash(string str)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(str);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash;
            }
        }

        public void SetNewPassword(string newPassword)
        {
            Settings.SetHashProgrammPassword(Hash(newPassword));
        }
    }
}
