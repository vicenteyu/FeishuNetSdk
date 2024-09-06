namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 加班审批 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/overtime</para>
    /// </summary>
    public record WorkApprovalEventBodyDto() : EventBodyDto("work_approval")
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
        [JsonPropertyName("employee_id")]
        public string? EmployeeId { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

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
        /// 加班类型
        /// </summary>
        [JsonPropertyName("work_type")]
        public string? WorkType { get; set; }

        /// <summary>
        /// 加班开始时间
        /// </summary>
        [JsonPropertyName("work_start_time")]
        public string? WorkStartTime { get; set; }

        /// <summary>
        /// 加班结束时间
        /// </summary>
        [JsonPropertyName("work_end_time")]
        public string? WorkEndTime { get; set; }

        /// <summary>
        /// 加班时长，单位（秒）
        /// </summary>
        [JsonPropertyName("work_interval")]
        public int WorkInterval { get; set; }

        /// <summary>
        /// 加班事由
        /// </summary>
        [JsonPropertyName("work_reason")]
        public string? WorkReason { get; set; }

        /// <summary>
        /// 1:存在多时段,0:不存在多时段
        /// </summary>
        [JsonPropertyName("allow_multi_time_range")]
        public int AllowMultiTimeRange { get; set; }

        /// <summary>
        /// 多时段，allow_multi_time_range为1时存在该字段
        /// </summary>
        [JsonPropertyName("time_range")]
        public TimeRangeSuffix[]? TimeRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record TimeRangeSuffix
        {
            /// <summary>
            /// 加班开始时间
            /// </summary>
            [JsonPropertyName("work_start_time")]
            public string WorkStartTime { get; set; } = string.Empty;

            /// <summary>
            /// 加班结束时间
            /// </summary>
            [JsonPropertyName("work_end_time")]
            public string WorkEndTime { get; set; } = string.Empty;
        }
    }
}
