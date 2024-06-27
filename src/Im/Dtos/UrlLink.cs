// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="UrlLink.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>全局跳转链接</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 全局跳转链接
    /// <para>url 和各端的链接（android_url、ios_url、pc_url）必填其中一个。如果不填写 url，则必须完整填写 android_url、ios_url、pc_url 三个字段。如果同时填写了 url 和 android_url、ios_url、pc_url，url 字段生效。</para>
    /// </summary>
    public record UrlLink
    {
        /// <summary>
        /// 默认的链接地址。
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// PC 端的链接地址。
        /// </summary>
        [JsonPropertyName("pc_url")]
        public string? PcUrl { get; set; }

        /// <summary>
        /// iOS 端的链接地址。
        /// </summary>
        [JsonPropertyName("ios_url")]
        public string? IosUrl { get; set; }

        /// <summary>
        /// Android 端的链接地址。
        /// </summary>
        [JsonPropertyName("android_url")]
        public string? AndroidUrl { get; set; }
    }

}
