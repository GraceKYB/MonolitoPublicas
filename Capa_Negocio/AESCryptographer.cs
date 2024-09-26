using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class AESCryptographer
    {
        private const string EncryptionKey = "Monolito4AM"; // Clave de encriptación. Asegúrate de cambiarla por una clave segura.
        private const string Salt = "GraceYaguachi"; // Valor aleatorio para mayor seguridad. Cambia esto también.

        // Método para encriptar una cadena de texto
        public static string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes;

            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(EncryptionKey, Encoding.UTF8.GetBytes(Salt));
                aes.Key = keyDerivation.GetBytes(32); // Tamaño de la clave (256 bits)
                aes.IV = keyDerivation.GetBytes(16); // Tamaño del vector de inicialización (128 bits)

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        encryptedBytes = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        // Método para desencriptar una cadena de texto
        public static string Decrypt(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] plainBytes = new byte[encryptedBytes.Length];

            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(EncryptionKey, Encoding.UTF8.GetBytes(Salt));
                aes.Key = keyDerivation.GetBytes(32); // Tamaño de la clave (256 bits)
                aes.IV = keyDerivation.GetBytes(16); // Tamaño del vector de inicialización (128 bits)

                using (MemoryStream memoryStream = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.Read(plainBytes, 0, plainBytes.Length);
                    }
                }
            }

            return Encoding.UTF8.GetString(plainBytes).TrimEnd('\0'); // Elimina caracteres nulos al final.
        }
    }
}
