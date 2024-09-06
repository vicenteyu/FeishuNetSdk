namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 请假审批 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/leave</para>
    /// </summary>
    public record LeaveApprovalV2EventBodyDto() : EventBodyDto("leave_approvalV2")
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 审批实例Code
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string? InstanceCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 销假单关联的原始单据
        /// </summary>
        [JsonPropertyName("origin_instance_code")]
        public string? OriginInstanceCode { get; set; }

        /// <summary>
        /// 审批发起时间，单位：秒
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 审批结束时间，单位：秒
        /// </summary>
        [JsonPropertyName("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 上班晚到（哺乳假相关）
        /// </summary>
        [JsonPropertyName("leave_feeding_arrive_late")]
        public int LeaveFeedingArriveLate { get; set; }

        /// <summary>
        /// 下班早走（哺乳假相关）
        /// </summary>
        [JsonPropertyName("leave_feeding_leave_early")]
        public int LeaveFeedingLeaveEarly { get; set; }

        /// <summary>
        /// 每日休息（哺乳假相关）
        /// </summary>
        [JsonPropertyName("leave_feeding_rest_daily")]
        public int LeaveFeedingRestDaily { get; set; }

        /// <summary>
        /// 假期名称
        /// </summary>
        [JsonPropertyName("leave_name")]
        public string? LeaveName { get; set; }

        /// <summary>
        /// 请假最小时长
        /// </summary>
        [JsonPropertyName("leave_unit")]
        public string? LeaveUnit { get; set; }

        /// <summary>
        /// 请假开始时间
        /// </summary>
        [JsonPropertyName("leave_start_time")]
        public string? LeaveStartTime { get; set; }

        /// <summary>
        /// 请假结束时间
        /// </summary>
        [JsonPropertyName("leave_end_time")]
        public string? LeaveEndTime { get; set; }

        /// <summary>
        /// 具体的请假明细时间
        /// </summary>
        [JsonPropertyName("leave_detail")]
        public string[][]? LeaveDetail { get; set; }

        /// <summary>
        /// 具体的请假时间范围
        /// </summary>
        [JsonPropertyName("leave_range")]
        public string[][]? LeaveRange { get; set; }

        /// <summary>
        /// 请假时长，单位（秒）
        /// </summary>
        [JsonPropertyName("leave_interval")]
        public int LeaveInterval { get; set; }

        /// <summary>
        /// 请假事由
        /// </summary>
        [JsonPropertyName("leave_reason")]
        public string? LeaveReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("i18n_resources")]
        public I18nResource[]? I18nResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record I18nResource
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("is_default")]
            public bool IsDefault { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("locale")]
            public string? Locale { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("texts")]
            public Dictionary<string, string>? Texts { get; set; }
        }
    }
}
