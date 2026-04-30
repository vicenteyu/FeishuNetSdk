// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="PostMinutesV1MinutesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索妙记 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 搜索妙记 响应体
/// <para>根据关键词、时间范围等条件搜索妙记，返回符合条件的妙记列表，包含妙记 token（用于标识妙记的唯一身份）、标题、开始时间等信息。</para>
/// <para>接口ID：7633638495471881156</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fsearch</para>
/// </summary>
public record PostMinutesV1MinutesSearchResponseDto : IPageableResponse<PostMinutesV1MinutesSearchResponseDto.MinutesSearchItem>
{
    /// <summary>
    /// <para>妙记列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MinutesSearchItem[] Items { get; set; } = [];

    /// <summary>
    /// <para>妙记列表</para>
    /// </summary>
    public record MinutesSearchItem
    {
        /// <summary>
        /// <para>妙记 Token（标识妙记唯一身份的凭证）</para>
        /// <para>必填：是</para>
        /// <para>示例值：obbcwkkdw885tetaf82pu184</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// <para>包含妙记基本信息的卡片，用户搜索关键词命中的文本片段，使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-03-28 产品&lt;h&gt;周会&lt;/h&gt;纪要</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>妙记元信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public MinutesMeta? MetaData { get; set; }

        /// <summary>
        /// <para>妙记元信息</para>
        /// </summary>
        public record MinutesMeta
        {
            /// <summary>
            /// <para>妙记跳转链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.feishu.cn/minutes/xxxxxx</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("app_link")]
            public string? AppLink { get; set; }

            /// <summary>
            /// <para>妙记封面图片 URL</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://p3-lark-file.byteimg.com/img/xxxx.jpg</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public string? Avatar { get; set; }

            /// <summary>
            /// <para>妙记描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：产品周会纪要</para>
            /// <para>最大长度：128</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }
        }
    }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
