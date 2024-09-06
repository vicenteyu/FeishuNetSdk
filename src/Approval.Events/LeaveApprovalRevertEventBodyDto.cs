namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 请假撤销消息 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/leave</para>
    /// </summary>
    public record LeaveApprovalRevertEventBodyDto() : EventBodyDto("leave_approval_revert")
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
        /// 
        /// </summary>
        [JsonPropertyName("operate_time")]
        public long OperateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
