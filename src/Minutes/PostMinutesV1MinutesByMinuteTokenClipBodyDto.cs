// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="PostMinutesV1MinutesByMinuteTokenClipBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建妙记片段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 创建妙记片段 请求体
/// <para>基于一篇已完成的妙记及指定的时间范围，创建一篇新的妙记片段。接口成功响应表示妙记片段已提交创建，不代表文字记录和媒体文件已生成完成，文字记录和媒体文件将在后台异步生成。</para>
/// <para>接口ID：7676147106222902224</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/clip</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fclip</para>
/// </summary>
public record PostMinutesV1MinutesByMinuteTokenClipBodyDto
{
    /// <summary>
    /// <para>片段时间区间（可填写多个区间，会拼接成一个妙记片段）</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("time_ranges")]
    public TimeRange[] TimeRanges { get; set; } = [];

    /// <summary>
    /// <para>片段时间区间（可填写多个区间，会拼接成一个妙记片段）</para>
    /// </summary>
    public record TimeRange
    {
        /// <summary>
        /// <para>起始时间（毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>截止时间（毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：20000</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }

    /// <summary>
    /// <para>片段标题（不填则生成默认标题）</para>
    /// <para>必填：否</para>
    /// <para>示例值：快速上手飞书妙记-片段</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
