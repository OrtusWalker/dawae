using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DaWae.Scripts
{ 
    public class Functions
    {
        private string hashAlgorithm = "SHA256";
        private int passwordIterations = 2;
        private string c38eeac2fadbff9e4ba31 = "NSdch8*&Huwli";
        private string a697570462f7565f23a0b2650653b81 = "nonsuch20142020";
        private string f5f23a0b2650653b81 = "!1A3g2D4s9K556g7";
        private int keySize = 256;

        public string hash(string text) => BitConverter.ToString(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(text))).Replace("-", "").ToLower();

        public void AuthRemind(ref string nickname, ref string password, bool remind)
        {
            if (remind)
            {
                using (StreamWriter text = new FileInfo("profile.dat").CreateText())
                {
                    text.WriteLine(nickname);
                    text.WriteLine(this.Encrypt(password, this.c38eeac2fadbff9e4ba31, this.a697570462f7565f23a0b2650653b81, this.hashAlgorithm, this.passwordIterations, this.f5f23a0b2650653b81, this.keySize));
                    text.WriteLine(remind.ToString());
                    text.WriteLine("NonSuchDev 2020.");
                }
            }
            else
            {
                using (StreamWriter text = new FileInfo("profile.dat").CreateText())
                {
                    text.WriteLine("");
                    text.WriteLine("");
                    text.WriteLine(0);
                    text.WriteLine("NonSuchDev 2020.");
                }
            }
        }

        public string Encrypt(
          string plainText,
          string passPhrase,
          string saltValue,
          string hashAlgorithm,
          int passwordIterations,
          string initVector,
          int keySize)
        {
            byte[] bytes1 = Encoding.ASCII.GetBytes(initVector);
            byte[] bytes2 = Encoding.ASCII.GetBytes(saltValue);
            byte[] bytes3 = Encoding.UTF8.GetBytes(plainText);
            byte[] bytes4 = new PasswordDeriveBytes(passPhrase, bytes2, hashAlgorithm, passwordIterations).GetBytes(keySize / 8);
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(bytes4, bytes1);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(bytes3, 0, bytes3.Length);
            cryptoStream.FlushFinalBlock();
            byte[] array = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(array);
        }

        public string Decrypt(
          string cipherText,
          string passPhrase,
          string saltValue,
          string hashAlgorithm,
          int passwordIterations,
          string initVector,
          int keySize)
        {
            byte[] bytes1 = Encoding.ASCII.GetBytes(initVector);
            byte[] bytes2 = Encoding.ASCII.GetBytes(saltValue);
            byte[] buffer = Convert.FromBase64String(cipherText);
            byte[] bytes3 = new PasswordDeriveBytes(passPhrase, bytes2, hashAlgorithm, passwordIterations).GetBytes(keySize / 8);
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(bytes3, bytes1);
            MemoryStream memoryStream = new MemoryStream(buffer);
            CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] numArray = new byte[buffer.Length];
            int count = cryptoStream.Read(numArray, 0, numArray.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(numArray, 0, count);
        }
    }
}