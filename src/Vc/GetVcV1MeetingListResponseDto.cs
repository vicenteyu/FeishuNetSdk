namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议明细 响应体
/// <para>查询会议明细，具体权限要求请参考「资源介绍」，支持查询最近半年的数据。</para>
/// <para>接口ID：7194805625628033027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting_list%2fget</para>
/// </summary>
public record GetVcV1MeetingListResponseDto
{
    /// <summary>
    /// <para>会议列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting_list")]
    public MeetingInfo[]? MeetingLists { get; set; }

    /// <summary>
    /// <para>会议列表</para>
    /// </summary>
    public record MeetingInfo
    {
        /// <summary>
        /// <para>9位会议号</para>
        /// <para>必填：否</para>
        /// <para>示例值：705605196</para>
        /// </summary>
        [JsonPropertyName("meeting_id")]
        public string? MeetingId { get; set; }

        /// <summary>
        /// <para>会议主题</para>
        /// <para>必填：否</para>
        /// <para>示例值：讨论会</para>
        /// </summary>
        [JsonPropertyName("meeting_topic")]
        public string? MeetingTopic { get; set; }

        /// <summary>
        /// <para>组织者</para>
        /// <para>必填：否</para>
        /// <para>示例值：kehan</para>
        /// </summary>
        [JsonPropertyName("organizer")]
        public string? Organizer { get; set; }

        /// <summary>
        /// <para>部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：development</para>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：92f879</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>工号</para>
        /// <para>必填：否</para>
        /// <para>示例值：202105149765</para>
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// <para>邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxx@163.com</para>
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>手机</para>
        /// <para>必填：否</para>
        /// <para>示例值：021-673288</para>
        /// </summary>
        [JsonPropertyName("mobile")]
        public string? Mobile { get; set; }

        /// <summary>
        /// <para>会议开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.23 11:16:59 (GMT+08:00)</para>
        /// </summary>
        [JsonPropertyName("meeting_start_time")]
        public string? MeetingStartTime { get; set; }

        /// <summary>
        /// <para>会议结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.23 11:18:51 (GMT+08:00)</para>
        /// </summary>
        [JsonPropertyName("meeting_end_time")]
        public string? MeetingEndTime { get; set; }

        /// <summary>
        /// <para>会议持续时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：00:01:52</para>
        /// </summary>
        [JsonPropertyName("meeting_duration")]
        public string? MeetingDuration { get; set; }

        /// <summary>
        /// <para>参会人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("number_of_participants")]
        public string? NumberOfParticipants { get; set; }

        /// <summary>
        /// <para>音频</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// <para>视频</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("video")]
        public bool? Video { get; set; }

        /// <summary>
        /// <para>共享</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("sharing")]
        public bool? Sharing { get; set; }

        /// <summary>
        /// <para>录制</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("recording")]
        public bool? Recording { get; set; }

        /// <summary>
        /// <para>电话</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("telephone")]
        public bool? Telephone { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
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
