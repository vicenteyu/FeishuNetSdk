// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="PostCorehrV2PathwaysBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建通道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建通道 请求体
/// <para>创建通道，可以定义通道的名称、编码和描述信息</para>
/// <para>接口ID：7508634905586958339</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fcreate</para>
/// </summary>
public record PostCorehrV2PathwaysBodyDto
{
    /// <summary>
    /// <para>编码</para>
    /// <para>必填：否</para>
    /// <para>示例值：A01234</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>名称</para>
    /// <para>必填：是</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("names")]
    public I18n[] Names { get; set; } = Array.Empty<I18n>();

    /// <summary>
    /// <para>名称</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>中文用zh-CN，英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>文本内容，最长支持255个字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：中文示例</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>描述</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("descriptions")]
    public I18n[]? Descriptions { get; set; }
}
