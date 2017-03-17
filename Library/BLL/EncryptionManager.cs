using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Library.BLL
{
    class EncryptionManager
    {
        private static RijndaelManaged algorithm = new RijndaelManaged();
        private const int MAX_FILE_SIZE = 50 * 1024 * 1024;

        static EncryptionManager()
        {
            algorithm.Padding = PaddingMode.Zeros;
        }
        private static byte[] encryptionIV = 
        {
            202, 9, 36, 77,
            53, 121, 255, 140,
            71, 188, 115, 168,
            103, 35, 41, 233
        };

        private static byte[] encryptionKey = 
        {
            85, 177, 250, 18,
            17, 86, 44, 134,
            53, 248, 129, 162,
            157, 88, 117, 78,

            226, 100, 113, 97,
            93, 201, 182, 83,
            133, 111, 214, 82,
            164, 133, 165, 191
        };

        public static byte[] Encrypt(byte[] data)
        {
            try
            {
                ICryptoTransform transform = algorithm.CreateEncryptor(encryptionKey, encryptionIV);
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

                return result;
            }
            catch (CryptographicException e)
            {
                throw new Exception(string.Format("A Cryptographic error occurred: {0}", e.Message));
            }
            catch (Exception)
            {
                throw new Exception("Error while writing to memory.");
            }
        }

        public static byte[] Decrypt(byte[] cipher)
        {
            try
            {
                ICryptoTransform transform = algorithm.CreateDecryptor(encryptionKey, encryptionIV);
                byte[] result = transform.TransformFinalBlock(cipher, 0, cipher.Length);

                return result;
            }
            catch (CryptographicException e)
            {
                throw new Exception(string.Format("A Cryptographic error occurred: {0}", e.Message));
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("An error occurred: {0}", e.Message));
            }
        }
    }
}

