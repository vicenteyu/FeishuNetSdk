namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取活跃会议 响应体
/// <para>获取一个预约的当前活跃会议。</para>
/// <para>接口ID：6921909217674952731</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/get_active_meeting</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fget_active_meeting</para>
/// </summary>
public record GetVcV1ReservesByReserveIdGetActiveMeetingResponseDto
{
    /// <summary>
    /// <para>会议数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting")]
    public GetVcV1ReservesByReserveIdGetActiveMeetingResponseDtoMeeting? Meeting { get; set; }

    /// <summary>
    /// <para>会议数据</para>
    /// </summary>
    public record GetVcV1ReservesByReserveIdGetActiveMeetingResponseDtoMeeting
    {
        /// <summary>
        /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411934433028</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>会议主题</para>
        /// <para>必填：否</para>
        /// <para>示例值：my meeting</para>
        /// </summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// <para>会议链接（飞书用户可通过点击会议链接快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://vc.feishu.cn/j/337736498</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>会议号</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议密码</para>
        /// <para>必填：否</para>
        /// <para>示例值：971024</para>
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// <para>会议创建时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608885566</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>会议开始时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608883322</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>会议结束时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608888867</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>主持人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("host_user")]
        public MeetingUser? HostUser { get; set; }

        /// <summary>
        /// <para>主持人</para>
        /// </summary>
        public record MeetingUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：飞书用户</item>
            /// <item>2：rooms用户</item>
            /// <item>3：文档用户</item>
            /// <item>4：neo单品用户</item>
            /// <item>5：neo单品游客用户</item>
            /// <item>6：pstn用户</item>
            /// <item>7：sip用户</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("user_type")]
            public int? UserType { get; set; }
        }

        /// <summary>
        /// <para>会议状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：会议呼叫中</item>
        /// <item>2：会议进行中</item>
        /// <item>3：会议已结束</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>参会峰值人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("participant_count")]
        public string? ParticipantCount { get; set; }

        /// <summary>
        /// <para>累计参会人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("participant_count_accumulated")]
        public string? ParticipantCountAccumulated { get; set; }

        /// <summary>
        /// <para>参会人列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("participants")]
        public MeetingParticipant[]? Participants { get; set; }

        /// <summary>
        /// <para>参会人列表</para>
        /// </summary>
        public record MeetingParticipant
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>首次入会时间，秒级Unix时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1624438144</para>
            /// </summary>
            [JsonPropertyName("first_join_time")]
            public string? FirstJoinTime { get; set; }

            /// <summary>
            /// <para>最终离会时间，秒级Unix时间戳</para>
            /// <para>必填：否</para>
            /// <para>示例值：1624438144</para>
            /// </summary>
            [JsonPropertyName("final_leave_time")]
            public string? FinalLeaveTime { get; set; }

            /// <summary>
            /// <para>累计在会中时间，时间单位：秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("in_meeting_duration")]
            public string? InMeetingDuration { get; set; }

            /// <summary>
            /// <para>用户类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：飞书用户</item>
            /// <item>2：rooms用户</item>
            /// <item>3：文档用户</item>
            /// <item>4：neo单品用户</item>
            /// <item>5：neo单品游客用户</item>
            /// <item>6：pstn用户</item>
            /// <item>7：sip用户</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("user_type")]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>是否为主持人</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_host")]
            public bool? IsHost { get; set; }

            /// <summary>
            /// <para>是否为联席主持人</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_cohost")]
            public bool? IsCohost { get; set; }

            /// <summary>
            /// <para>是否为外部参会人</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_external")]
            public bool? IsExternal { get; set; }

            /// <summary>
            /// <para>参会人状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：呼叫中</item>
            /// <item>2：在会中</item>
            /// <item>3：正在响铃</item>
            /// <item>4：不在会中或已经离开会议</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }
        }

        /// <summary>
        /// <para>会中使用的能力</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ability")]
        public MeetingAbility? Ability { get; set; }

        /// <summary>
        /// <para>会中使用的能力</para>
        /// </summary>
        public record MeetingAbility
        {
            /// <summary>
            /// <para>是否使用视频</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("use_video")]
            public bool? UseVideo { get; set; }

            /// <summary>
            /// <para>是否使用音频</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("use_audio")]
            public bool? UseAudio { get; set; }

            /// <summary>
            /// <para>是否使用共享屏幕</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("use_share_screen")]
            public bool? UseShareScreen { get; set; }

            /// <summary>
            /// <para>是否使用妙享（magic share）</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("use_follow_screen")]
            public bool? UseFollowScreen { get; set; }

            /// <summary>
            /// <para>是否使用录制</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("use_recording")]
            public bool? UseRecording { get; set; }

            /// <summary>
            /// <para>是否使用PSTN</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("use_pstn")]
            public bool? UsePstn { get; set; }
        }
    }
}
