namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 换班审批 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/shift-change</para>
    /// </summary>
    public record ShiftApprovalEventBodyDto() : EventBodyDto("shift_approval")
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 企业唯一标识
        /// </summary>
        [JsonPropertyName("tenant_key")]
        public string? TenantKey { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 审批实例的唯一标识
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
        /// 换班时间  
        /// </summary>
        [JsonPropertyName("shift_time")]
        public string? ShiftTime { get; set; }

        /// <summary>
        /// 还班时间  
        /// </summary>
        [JsonPropertyName("return_time")]
        public string? ReturnTime { get; set; }

        /// <summary>
        /// 换班事由
        /// </summary>
        [JsonPropertyName("shift_reason")]
        public string? ShiftReason { get; set; }
    }
}
