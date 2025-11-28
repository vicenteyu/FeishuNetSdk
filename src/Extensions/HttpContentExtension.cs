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
namespace FeishuNetSdk.Extensions
{
    internal static class HttpContentExtension
    {
        public static bool IsJsonContent(this System.Net.Http.Headers.HttpContentHeaders headers)
        {
            return headers.Any(p => p.Key == "Content-Type" && p.Value.Any(k => k.Contains("application/json")));
        }
    }
}
