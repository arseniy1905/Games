using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Games.Common.Utils
{
    public class AesHelper
    {
        private static string Key
        {
            get { return "MjSd+3LvKo9jFqWzGFJNvn+S+DmX0WWU3sojaOhQFHQ="; }
        }

        private static string IV
        {
            get { return "gWdjIhvCME7OTIEQjmpU0A=="; }
        }

        /// <summary>
        /// Generate Key and IV for encryption
        /// </summary>
        /// <returns> Dictionary of Key and IV values</returns>
        public static Dictionary<string, string> GenerateKeyIV()
        {
            Dictionary<string, string> lstKeyIV = new Dictionary<string, string>();

            AesCryptoServiceProvider crypto = new AesCryptoServiceProvider();

            crypto.KeySize = 256;
            crypto.GenerateKey();
            crypto.GenerateIV();

            byte[] key = crypto.Key;
            byte[] IV = crypto.IV;

            string keyOutput = Convert.ToBase64String(key);
            lstKeyIV.Add("Key", keyOutput);

            string ivOutput = Convert.ToBase64String(IV);
            lstKeyIV.Add("IV", ivOutput);

            return lstKeyIV;
        }

        /// <summary>
        /// Creates a new instance of a AesCryptoServiceProvider class initialzied with the hard-coded application key and IV.
        /// The same instance can be used in multiple encryption and decryption but must be disposed when done
        /// </summary>
        /// <returns></returns>
        private static AesCryptoServiceProvider CreateCryptoServiceProvider()
        {
            AesCryptoServiceProvider aesAlgorithm = null;

            try
            {
                aesAlgorithm = new AesCryptoServiceProvider
                {
                    Key = Convert.FromBase64String(Key),
                    IV = Convert.FromBase64String(IV)
                };

                return aesAlgorithm;
            }
            catch (Exception ex)
            {
                IDisposable disposable = aesAlgorithm;
                if (disposable != null)
                {
                    disposable.Dispose();
                }

                throw ex;
            }
        }


        /// <summary>
        /// Encrypts an array of bytes into an array of bytes.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="plainData">The array of bytes to encrypt.</param>
        /// <returns>
        /// Returns an array of bytes of the cipher. 
        /// Returns null if plainData is null, returns an empty array if plainData is empty.
        /// </returns>
        private static byte[] EncryptToByteArray(SymmetricAlgorithm aesAlgorithm, byte[] plainData)
        {
            if (plainData == null)
            {
                return null;
            }

            if (plainData.Length == 0)
            {
                return new byte[0];
            }

            ThrowExceptionIfNull(aesAlgorithm, "aesAlgorithm");

            // Create a decryptor to perform the stream transform.
            ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    //Write all data to the stream.
                    csEncrypt.Write(plainData, 0, plainData.Length);
                }

                return msEncrypt.ToArray();
            }
        }

        /// <summary>
        /// Encrypts an array of bytes into an array of bytes.
        /// </summary>
        /// <param name="plainData">The array of bytes to encrypt.</param>
        /// <returns>
        /// Returns an array of bytes of the cipher. 
        /// Returns null if plainData is null, returns an empty array if plainData is empty.
        /// </returns>
        public static byte[] EncryptToByteArray(byte[] plainData)
        {
            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return EncryptToByteArray(aesAlgorithm, plainData);
            }
        }

        /// <summary>
        /// Encrypts an array of bytes and returns the cipher in base-64 format.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="plainData">The array of bytes to encrypt.</param>
        /// <returns>
        /// Returns the cipher in base-64 format.
        /// Returns null if plainData is null, returns an empty string if plainData is empty.
        /// </returns>
        public static string EncryptToBase64(SymmetricAlgorithm aesAlgorithm, byte[] plainData)
        {
            if (plainData == null)
            {
                return null;
            }

            if (plainData.Length == 0)
            {
                return string.Empty;
            }

            ThrowExceptionIfNull(aesAlgorithm, "aesAlgorithm");

            return Convert.ToBase64String(EncryptToByteArray(aesAlgorithm, plainData));
        }

        /// <summary>
        /// Encrypts an array of bytes and returns the cipher in base-64 format.
        /// </summary>
        /// <param name="plainData">The array of bytes to encrypt.</param>
        /// <returns>
        /// Returns the cipher in base-64 format.
        /// Returns null if plainData is null, returns an empty string if plainData is empty.
        /// </returns>
        public static string EncryptToBase64(byte[] plainData)
        {
            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return EncryptToBase64(aesAlgorithm, plainData);
            }
        }

        /// <summary>
        /// Encrypts a string into an array of bytes.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="plainText">The text to encrypt.</param>
        /// <returns>
        /// Returns an array of bytes of the cipher. 
        /// Returns null if plainText is null, returns an empty array if plainText is empty.
        /// </returns>
        private static byte[] EncryptToByteArray(SymmetricAlgorithm aesAlgorithm, string plainText)
        {
            if (plainText == null)
            {
                return null;
            }

            if (plainText.Length == 0)
            {
                return new byte[0];
            }

            ThrowExceptionIfNull(aesAlgorithm, "aesAlgorithm");

            // Create a decryptor to perform the stream transform.
            ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt, Encoding.Unicode))
                {
                    //Write all data to the stream.
                    swEncrypt.Write(plainText);
                }

                return msEncrypt.ToArray();
            }
        }

        /// <summary>
        /// Encrypts a string and returns the resulting cipher in base-64 format.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="plainText">The text to encrypt.</param>
        /// <returns>
        /// Returns the resulting cipher in base-64 format. 
        /// Returns null if plainText is null, returns an empty string if plainText is empty.
        /// </returns>
        private static string EncryptToBase64(SymmetricAlgorithm aesAlgorithm, string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return plainText;
            }

            return Convert.ToBase64String(EncryptToByteArray(aesAlgorithm, plainText));
        }

        /// <summary>
        /// Encrypts a string into an array of bytes.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <returns>
        /// Returns an array of bytes of the cipher. 
        /// Returns null if plainText is null, returns an empty array if plainText is empty.
        /// </returns>
        private static byte[] EncryptToByteArray(string plainText)
        {
            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return EncryptToByteArray(aesAlgorithm, plainText);
            }
        }

        /// <summary>
        /// Encrypts a string and returns the resulting cipher in base-64 format.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <returns>
        /// Returns the resulting cipher in base-64 format. 
        /// Returns null if plainText is null, returns an empty string if plainText is empty.
        /// </returns>
        public static string EncryptToBase64(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return plainText;
            }

            return Convert.ToBase64String(EncryptToByteArray(plainText));
        }

        public static string URLEncodedEncryptToBase64(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                return plainText;
            }

            var x = Convert.ToBase64String(EncryptToByteArray(plainText));
            return HttpUtility.UrlEncode(x);
        }

        /// <summary>
        /// Decrypts an array of bytes into a string, the cipher must be an encrpytion of a Unicode string.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="cipher">The cipher to decrypt.</param>
        /// <returns>
        /// Returns the decrypted text of the specified byte array cipher.
        /// Returns null if cipher is null, returns an empty string if cipher is empty.
        /// </returns>
        private static string DecryptToString(SymmetricAlgorithm aesAlgorithm, byte[] cipher)
        {
            if (cipher == null)
            {
                return null;
            }

            if (cipher.Length == 0)
            {
                return string.Empty;
            }

            ThrowExceptionIfNull(aesAlgorithm, "aesAlgorithm");

            // Create a decryptor to perform the stream transform.
            ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(cipher))
            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (StreamReader srDecrypt = new StreamReader(csDecrypt, Encoding.Unicode))
            {
                // Read the decrypted bytes from the decrypting stream
                // and return them in a string.
                return srDecrypt.ReadToEnd();
            }
        }

        /// <summary>
        /// Decrypts a string cipher in base-64 format, the cipher must be an encryption of a Unicode string.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="cipher">The string cipher to decrypt.</param>
        /// <returns>
        /// Returns the decrypted string. 
        /// Returns null if cipher is null, returns an emtpy string if cipher is empty.
        /// </returns>
        private static string DecryptToString(SymmetricAlgorithm aesAlgorithm, string cipher)
        {
            if (string.IsNullOrEmpty(cipher))
            {
                return cipher;
            }

            return DecryptToString(aesAlgorithm, Convert.FromBase64String(cipher));
        }

        /// <summary>
        /// Decrypts an array of bytes into a string, the cipher must be an encrpytion of a Unicode string.
        /// </summary>
        /// <param name="cipher">The cipher to decrypt.</param>
        /// <returns>
        /// Returns the decrypted text of the specified byte array cipher.
        /// Returns null if cipher is null, returns an empty string if cipher is empty.
        /// </returns>
        public static string DecryptToString(byte[] cipher)
        {
            if (cipher == null)
            {
                return null;
            }

            if (cipher.Length == 0)
            {
                return string.Empty;
            }

            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return DecryptToString(aesAlgorithm, cipher);
            }
        }

        private static byte[] DecryptToByteArray(SymmetricAlgorithm aesAlgorithm, byte[] cipher)
        {
            if (cipher == null)
            {
                return null;
            }

            if (cipher.Length == 0)
            {
                return null;
            }

            ThrowExceptionIfNull(aesAlgorithm, "aesAlgorithm");

            // Create a decryptor to perform the stream transform.
            ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(cipher))
            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
            //using (StreamReader srDecrypt = new StreamReader(csDecrypt, Encoding.Unicode))
            {
                // Read the decrypted bytes from the decrypting stream
                // and return them in a string.
                csDecrypt.Write(cipher, 0, cipher.Length);
                return msDecrypt.ToArray();
            }

        }

        public static byte[] DecryptToByteArray(byte[] cipher)
        {
            if (cipher == null)
            {
                return null;
            }

            if (cipher.Length == 0)
            {
                return null;
            }

            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return DecryptToByteArray(aesAlgorithm, cipher);
            }
        }
        /// <summary>
        /// Decrypts a string in base-64 format, it must be an encryption of a Unicode string.
        /// </summary>
        /// <param name="cipher">The string to decrypt.</param>
        /// <returns>
        /// Returns the decrypted string. 
        /// Returns null if cipher is null, returns an emtpy string if cipher is empty.
        /// </returns>
        public static string DecryptToString(string cipher)
        {
            if (string.IsNullOrEmpty(cipher))
            {
                return cipher;
            }

            return DecryptToString(Convert.FromBase64String(cipher));
        }

        public static string DecryptURLToString(string cipher)
        {
            if (string.IsNullOrEmpty(cipher))
            {
                return cipher;
            }

            cipher = cipher.Replace(' ', '+');
            return DecryptToString(Convert.FromBase64String(cipher));
        }



        private const string DateFormat = "dd MMM yyyy HH':'mm':'ss 'GMT'";


        /// <summary>
        /// Encrypts a nullable DateTime and returns the cipher as a string in base-64 format.
        /// </summary>
        /// <param name="dateTime">The DateTime object to encrypt.</param>
        /// <returns>
        /// Returns the base-64 cipher of the specified DataTime. Returns null if dateTime is null.
        /// </returns>
        public static string EncryptDate(DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }

            return EncryptDate(dateTime.Value);
        }

        /// <summary>
        /// Encrypts a DateTime and returns the cipher as a string in base-64 format.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="dateTime">The DateTime object to encrypt.</param>
        /// <returns>Returns the base-64 cipher of the specified DateTime.</returns>
        public static string EncryptDate(SymmetricAlgorithm aesAlgorithm, DateTime dateTime)
        {
            ThrowExceptionIfNull(aesAlgorithm, "aesAlgorithm");

            string dateString = dateTime.ToString(DateFormat, CultureInfo.InvariantCulture);

            return EncryptToBase64(aesAlgorithm, dateString);
        }

        /// <summary>
        /// Encrypts a DateTime and returns the string in base-64 format.
        /// </summary>
        /// <param name="dateTime">The DateTime object to encrypt.</param>
        /// <returns>Returns the base-64 string of the specified DateTime.</returns>
        public static string EncryptDate(DateTime dateTime)
        {
            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return EncryptDate(aesAlgorithm, dateTime);
            }
        }


        /// <summary>
        /// Decrypts a base-64 string into a DateTime. The string must be an encryption of a DateTime.
        /// </summary>
        /// <param name="aesAlgorithm">The AesCryptoServiceProvider to use.</param>
        /// <param name="dateString">The base-64 string to decrypt.</param>
        /// <returns>
        /// Returns the decrypted DateTime.
        /// </returns>
        public static DateTime DecryptToDateTime(SymmetricAlgorithm aesAlgorithm, string dateString)
        {
            ThrowExceptionIfNull(dateString, "dateString");

            string date = DecryptToString(aesAlgorithm, dateString);

            return DateTime.ParseExact(date, DateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Decrypts a base-64 string into a DateTime. The string must be an encryption of a DateTime.
        /// </summary>
        /// <param name="dateString">The base-64 string to decrypt.</param>
        /// <returns>
        /// Returns the decrypted DateTime.
        /// </returns>
        public static DateTime DecryptToDateTime(string dateString)
        {
            using (AesCryptoServiceProvider aesAlgorithm = CreateCryptoServiceProvider())
            {
                return DecryptToDateTime(aesAlgorithm, dateString);
            }
        }


        #region PrivateVariables
        private static void ThrowExceptionIfNull(object param, string paramName)
        {
            if (param == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        private static void ThrowArgumentEmptyException(string paramName)
        {
            string message = string.Format(CultureInfo.InvariantCulture, "{0} is empty", paramName);

            throw new ArgumentException(message);
        }
        #endregion
    }
}
