// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoTimeZonesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询时区信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询时区信息 响应体
/// <para>根据时区 ID、状态，批量查询时区信息</para>
/// <para>接口ID：7424038983966441473</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-time_zone/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-time_zone%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoTimeZonesSearchResponseDto
{
    /// <summary>
    /// <para>查询到的时区列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TimeZone[]? Items { get; set; }

    /// <summary>
    /// <para>查询到的时区列表</para>
    /// </summary>
    public record TimeZone
    {
        /// <summary>
        /// <para>时区 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6862995813451171342</para>
        /// </summary>
        [JsonPropertyName("time_zone_id")]
        public string? TimeZoneId { get; set; }

        /// <summary>
        /// <para>时区名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>时区名称</para>
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
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：Pacific/Niue</para>
        /// </summary>
        [JsonPropertyName("time_zone_code")]
        public string? TimeZoneCode { get; set; }

        /// <summary>
        /// <para>UTC 时区偏移量</para>
        /// <para>必填：否</para>
        /// <para>示例值：-660</para>
        /// </summary>
        [JsonPropertyName("utc_offset")]
        public string? UtcOffset { get; set; }

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
    /// <para>示例值：6862995813451171342</para>
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
