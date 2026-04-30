// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-01
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="PostMinutesV1MinutesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索妙记 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 搜索妙记 请求体
/// <para>根据关键词、时间范围等条件搜索妙记，返回符合条件的妙记列表，包含妙记 token（用于标识妙记的唯一身份）、标题、开始时间等信息。</para>
/// <para>接口ID：7633638495471881156</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fsearch</para>
/// </summary>
public record PostMinutesV1MinutesSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词</para>
    /// <para>必填：否</para>
    /// <para>示例值：周会</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>妙记搜索的过滤条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("filter")]
    public MinutesFilter? Filter { get; set; }

    /// <summary>
    /// <para>妙记搜索的过滤条件</para>
    /// </summary>
    public record MinutesFilter
    {
        /// <summary>
        /// <para>按妙记创建者过滤，传入用户 open_id 列表，可通过用户查询接口获取。默认值为空数组，不设置时不过滤该条件。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("owner_ids")]
        public string[]? OwnerIds { get; set; }

        /// <summary>
        /// <para>按妙记参与者过滤，传入用户 open_id 列表，可通过用户查询接口获取。默认值为空数组，不设置时不过滤该条件。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("participant_ids")]
        public string[]? ParticipantIds { get; set; }

        /// <summary>
        /// <para>按妙记创建时间过滤，传入时间范围对象。其中 start_time 必须小于等于 end_time</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public TimeRange? CreateTime { get; set; }

        /// <summary>
        /// <para>按妙记创建时间过滤，传入时间范围对象。其中 start_time 必须小于等于 end_time</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>起始时间，需符合 ISO 8601 标准并携带时区信息（create_time 的子参数</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间，需符合 ISO 8601 标准并携带时区信息（create_time 的子参数</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }
    }

    /// <summary>
    /// <para>排序参数，默认按照相关性规则排序</para>
    /// <para>必填：否</para>
    /// <para>示例值：create_time_desc</para>
    /// <para>可选值：<list type="bullet">
    /// <item>create_time_desc：按照妙记创建时间降序排序</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("sorter")]
    public string? Sorter { get; set; }
}
