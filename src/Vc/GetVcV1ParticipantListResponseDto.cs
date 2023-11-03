using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询参会人明细 响应体
/// <para>查询参会人明细（仅支持已结束会议），具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7194805625628147715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fparticipant_list%2fget</para>
/// </summary>
public record GetVcV1ParticipantListResponseDto
{
    /// <summary>
    /// <para>参会人列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("participants")]
    public Participant[]? Participants { get; set; }

    /// <summary>
    /// <para>参会人列表</para>
    /// </summary>
    public record Participant
    {
        /// <summary>
        /// <para>参会者</para>
        /// <para>必填：否</para>
        /// <para>示例值：kehan</para>
        /// </summary>
        [JsonProperty("participant_name")]
        public string? ParticipantName { get; set; }

        /// <summary>
        /// <para>部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：development</para>
        /// </summary>
        [JsonProperty("department")]
        public string? Department { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：8efq90</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>会议室ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_8efq90</para>
        /// </summary>
        [JsonProperty("meeting_room_id")]
        public string? MeetingRoomId { get; set; }

        /// <summary>
        /// <para>工号</para>
        /// <para>必填：否</para>
        /// <para>示例值：202205789</para>
        /// </summary>
        [JsonProperty("employee_id")]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// <para>电话</para>
        /// <para>必填：否</para>
        /// <para>示例值：021-883889</para>
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// <para>邮箱</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxxx@163.com</para>
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <para>设备</para>
        /// <para>必填：否</para>
        /// <para>示例值：windows</para>
        /// <para>默认值：windows</para>
        /// </summary>
        [JsonProperty("device")]
        public string? Device { get; set; }

        /// <summary>
        /// <para>客户端版本</para>
        /// <para>必填：否</para>
        /// <para>示例值：5.26.0-alpha.38</para>
        /// </summary>
        [JsonProperty("app_version")]
        public string? AppVersion { get; set; }

        /// <summary>
        /// <para>公网IP</para>
        /// <para>必填：否</para>
        /// <para>示例值：27.xx.xx.183</para>
        /// </summary>
        [JsonProperty("public_ip")]
        public string? PublicIp { get; set; }

        /// <summary>
        /// <para>内网IP</para>
        /// <para>必填：否</para>
        /// <para>示例值：192.xx.xx.13</para>
        /// </summary>
        [JsonProperty("internal_ip")]
        public string? InternalIp { get; set; }

        /// <summary>
        /// <para>代理服务</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("use_rtc_proxy")]
        public bool? UseRtcProxy { get; set; }

        /// <summary>
        /// <para>位置</para>
        /// <para>必填：否</para>
        /// <para>示例值：东莞</para>
        /// </summary>
        [JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// <para>网络类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：wifi</para>
        /// </summary>
        [JsonProperty("network_type")]
        public string? NetworkType { get; set; }

        /// <summary>
        /// <para>连接类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：udp</para>
        /// </summary>
        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        /// <summary>
        /// <para>麦克风</para>
        /// <para>必填：否</para>
        /// <para>示例值：麦克风阵列 (Realtek(R) Audio)</para>
        /// <para>默认值：mic</para>
        /// </summary>
        [JsonProperty("microphone")]
        public string? Microphone { get; set; }

        /// <summary>
        /// <para>扬声器</para>
        /// <para>必填：否</para>
        /// <para>示例值：扬声器 (Realtek(R) Audio)</para>
        /// </summary>
        [JsonProperty("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// <para>摄像头</para>
        /// <para>必填：否</para>
        /// <para>示例值：HD Camera</para>
        /// </summary>
        [JsonProperty("camera")]
        public string? Camera { get; set; }

        /// <summary>
        /// <para>音频</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// <para>视频</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("video")]
        public bool? Video { get; set; }

        /// <summary>
        /// <para>共享</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("sharing")]
        public bool? Sharing { get; set; }

        /// <summary>
        /// <para>入会时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.23 11:16:59 (GMT+08:00)</para>
        /// </summary>
        [JsonProperty("join_time")]
        public string? JoinTime { get; set; }

        /// <summary>
        /// <para>离会时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.23 11:18:51 (GMT+08:00)</para>
        /// </summary>
        [JsonProperty("leave_time")]
        public string? LeaveTime { get; set; }

        /// <summary>
        /// <para>参会时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：00:01:52</para>
        /// </summary>
        [JsonProperty("time_in_meeting")]
        public string? TimeInMeeting { get; set; }

        /// <summary>
        /// <para>离会原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：主持人结束会议</para>
        /// </summary>
        [JsonProperty("leave_reason")]
        public string? LeaveReason { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}
