// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="AesCipher.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>AES解密方法类</summary>
// ************************************************************************
using System.Security.Cryptography;
using System.Text;

namespace FeishuNetSdk.Services
{
    /// <summary>
    /// AES解密方法类
    /// </summary>
    public class AesCipher
    {
        const int BlockSize = 16;

        /// <summary>
        /// 字符串解密
        /// </summary>
        public static string DecryptString(string encryptString, string encryptKey)
        {
            byte[] encBytes = Convert.FromBase64String(encryptString);
            var rijndaelManaged = Aes.Create();
            rijndaelManaged.Key = SHA256Hash(encryptKey);
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.IV = [.. encBytes.Take(BlockSize)];
            ICryptoTransform transform = rijndaelManaged.CreateDecryptor();
            byte[] blockBytes = transform.TransformFinalBlock(encBytes, BlockSize, encBytes.Length - BlockSize);
            return Encoding.UTF8.GetString(blockBytes);
        }

        private static byte[] SHA256Hash(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return SHA256.HashData(bytes);
        }
    }
}
