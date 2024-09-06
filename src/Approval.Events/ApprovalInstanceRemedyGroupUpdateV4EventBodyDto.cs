namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 补卡审批 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/attendance-record-correction</para>
    /// </summary>
    public record ApprovalInstanceRemedyGroupUpdateV4EventBodyDto() : EventBodyDto("approval.instance.remedy_group_update_v4")
    {
        /// <summary>
        /// 为当前的数据,事件的标准格式
        /// </summary>
        [JsonPropertyName("object")]
        public ObjectSuffix Object { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        public record ObjectSuffix
        {
            /// <summary>
            /// 类型
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// 审批实例code
            /// </summary>
            [JsonPropertyName("instance_code")]
            public string? InstanceCode { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [JsonPropertyName("employee_id")]
            public string? EmployeeId { get; set; }

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
            /// 补卡时间，单位：毫秒
            /// </summary>
            [JsonPropertyName("remedy_time")]
            public long RemedyTime { get; set; }

            /// <summary>
            /// 补卡原因
            /// </summary>
            [JsonPropertyName("remedy_reason")]
            public string? RemedyReason { get; set; }

            /// <summary>
            /// 实例状态
            /// </summary>
            [JsonPropertyName("status")]
            public string? Status { get; set; }
        }
    }
}
