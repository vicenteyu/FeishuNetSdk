// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="HttpContentExtension.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace FeishuNetSdk
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    internal static class HttpContentExtension
    {
        public static bool IsJsonContent(this System.Net.Http.Headers.HttpContentHeaders headers)
        {
            return headers.Any(p => p.Key == "Content-Type" && p.Value.Any(k => k.Contains("application/json")));
        }
    }
}
