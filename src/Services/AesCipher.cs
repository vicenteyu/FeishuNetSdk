// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="AesCipher.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>AES解密方法类</summary>
// ************************************************************************
global using FeishuNetSdk.Services;
using Microsoft.Extensions.Options;
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
        private readonly IOptionsMonitor<FeishuNetSdkOptions> _options;

        /// <summary>
        /// AES解密方法类
        /// </summary>
        public AesCipher(IOptionsMonitor<FeishuNetSdkOptions> options)
        {
            _options = options;
        }

        /// <summary>
        /// 字符串解密
        /// </summary>
        public string DecryptString(string encryptString)
        {
            var EncryptKey = _options.CurrentValue.EncryptKey
                ?? throw new Exception("未设置解密密钥");

            byte[] encBytes = Convert.FromBase64String(encryptString);
            var rijndaelManaged = Aes.Create();
            rijndaelManaged.Key = SHA256Hash(EncryptKey);
            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.IV = encBytes.Take(BlockSize).ToArray();
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
