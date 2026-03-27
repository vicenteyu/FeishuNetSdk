// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PostVcV1MeetingsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索会议记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 搜索会议记录 请求体
/// <para>根据关键词、时间范围等条件搜索会议记录，返回符合条件的会议列表，包含会议 ID、主题、开始时间及参与者等信息。</para>
/// <para>接口ID：7621540721572694970</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fsearch</para>
/// </summary>
public record PostVcV1MeetingsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词</para>
    /// <para>**数据校验规则：** 长度范围：1 字符 ～ 50 字符</para>
    /// <para>必填：否</para>
    /// <para>示例值：周会</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// <para>会议搜索的过滤条件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting_filter")]
    public MeetingFilterSuffix? MeetingFilter { get; set; }

    /// <summary>
    /// <para>会议搜索的过滤条件</para>
    /// </summary>
    public record MeetingFilterSuffix
    {
        /// <summary>
        /// <para>按会议组织者过滤，传入用户 open_id 列表，可通过用户查询接口获取。默认值为空数组，不设置时不过滤该条件。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("organizer_ids")]
        public string[]? OrganizerIds { get; set; }

        /// <summary>
        /// <para>按参会人过滤，传入用户 open_id 列表，可通过用户查询接口获取。默认值为空数组，不设置时不过滤该条件。长度范围：0～128。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("participant_ids")]
        public string[]? ParticipantIds { get; set; }

        /// <summary>
        /// <para>按会议室过滤，传入会议室 open_id 列表，可通过会议室查询接口获取。默认值为空数组，不设置时不过滤该条件。长度范围：0～128。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：128</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("open_room_ids")]
        public string[]? OpenRoomIds { get; set; }

        /// <summary>
        /// <para>按会议开始时间过滤，传入时间范围对象。其中 start_time 必须小于等于 end_time（即 meeting_filter.start_time.end_time）。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public TimeRange? StartTime { get; set; }

        /// <summary>
        /// <para>按会议开始时间过滤，传入时间范围对象。其中 start_time 必须小于等于 end_time（即 meeting_filter.start_time.end_time）。</para>
        /// </summary>
        public record TimeRange
        {
            /// <summary>
            /// <para>时间范围的起始时间，需符合 ISO 8601 标准并携带时区信息。</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>时间范围的结束时间，需符合 ISO 8601 标准并携带时区信息。</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-03-21T16:15:30+08:00</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }
    }
}
