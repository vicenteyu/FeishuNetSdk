// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoLanguagesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询语言信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询语言信息 响应体
/// <para>根据语言 ID、状态，批量查询语言信息</para>
/// <para>接口ID：7424038983966425089</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-language/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-language%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoLanguagesSearchResponseDto
{
    /// <summary>
    /// <para>查询到的语言列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Language[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的语言列表</para>
    /// </summary>
    public record Language
    {
        /// <summary>
        /// <para>语言 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6863323445740963342</para>
        /// </summary>
        [JsonPropertyName("language_id")]
        public string? LanguageId { get; set; }

        /// <summary>
        /// <para>语言名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>语言名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言编码（IETF BCP 47）</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：英文（英国）</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>IETF 编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：en-UK</para>
        /// </summary>
        [JsonPropertyName("ietf_language_tag")]
        public string? IetfLanguageTag { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：生效</item>
        /// <item>0：失效</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6863323445740963342</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
