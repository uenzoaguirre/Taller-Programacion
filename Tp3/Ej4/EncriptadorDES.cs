using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Text;


namespace Ej4
{

    public class EncriptadorDES : Encriptador
    {
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("ZeroCool");
        public EncriptadorDES() : base("DES")
        {

        }



        public override string Encriptar(string pCadena)
        {
            if (String.IsNullOrEmpty(pCadena))
            {
                throw new ArgumentNullException
                ("The string which needs to be encrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
            cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(pCadena);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public override string Desencriptar(string pCadena)
        {
            if (String.IsNullOrEmpty(pCadena))
            {
                throw new ArgumentNullException
                   ("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(pCadena));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
    }
}
