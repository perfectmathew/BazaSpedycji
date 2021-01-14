using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; 
namespace AESCrypto
{
    class Encyryption
    {
        public static string IV = "qo1lc3sjd8zpt9cx";
        public static string Key = "ow7dxys8glfor9tnc2ansdfoltekfjcv"; 
        public static string Encrypt(string decrypted)
        {
            byte[] texbyte = ASCIIEncoding.ASCII.GetBytes(decrypted);
            AesCryptoServiceProvider encoder = new AesCryptoServiceProvider();
            encoder.BlockSize = 128;
            encoder.KeySize = 256;
            encoder.Key= ASCIIEncoding.ASCII.GetBytes(Key);
            encoder.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            encoder.Padding = PaddingMode.PKCS7;
            encoder.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = encoder.CreateEncryptor(encoder.Key, encoder.IV);
            byte[] enc = icrypt.TransformFinalBlock(texbyte, 0, texbyte.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }
        public static string Decrypt(string encrypted)
        {
            byte[] encbyte = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider encoder = new AesCryptoServiceProvider();
            encoder.BlockSize = 128;
            encoder.KeySize = 256;
            encoder.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            encoder.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            encoder.Padding = PaddingMode.PKCS7;
            encoder.Mode = CipherMode.CBC;
            ICryptoTransform icrypt = encoder.CreateDecryptor(encoder.Key, encoder.IV);
            byte[] dec = icrypt.TransformFinalBlock(encbyte, 0, encbyte.Length);
            icrypt.Dispose();
            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}
