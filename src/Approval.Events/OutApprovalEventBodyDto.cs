// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="OutApprovalEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>外出审批 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 外出审批 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/out-of-office</para>
    /// </summary>
    public record OutApprovalEventBodyDto() : EventBodyDto("out_approval")
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
        /// 
        /// </summary>
        [JsonPropertyName("i18n_resources")]
        public I18nResource[]? I18nResources { get; set; }

        /// <summary>
        /// 此审批的唯一标识
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string? InstanceCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("out_image")]
        public string? OutImage { get; set; }

        /// <summary>
        /// 外出时长，单位秒
        /// </summary>
        [JsonPropertyName("out_interval")]
        public int? OutInterval { get; set; }

        /// <summary>
        /// 通过i18n_resources里的信息换取相应语言的文案
        /// </summary>
        [JsonPropertyName("out_name")]
        public string? OutName { get; set; }

        /// <summary>
        /// 外出事由
        /// </summary>
        [JsonPropertyName("out_reason")]
        public string? OutReason { get; set; }

        /// <summary>
        /// 外出开始
        /// </summary>
        [JsonPropertyName("out_start_time")]
        public string? OutStartTime { get; set; }

        /// <summary>
        /// 外出结束
        /// </summary>
        [JsonPropertyName("out_end_time")]
        public string? OutEndTime { get; set; }

        /// <summary>
        /// 外出时长的单位，HOUR 小时，DAY 天，HALF_DAY 半天
        /// </summary>
        [JsonPropertyName("out_unit")]
        public string? OutUnit { get; set; }

        /// <summary>
        /// 审批开始时间，单位：秒
        /// </summary>
        [JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// 审批结束时间，单位：秒
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// 申请发起人open_id
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// // 申请发起人
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record I18nResource
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("is_default")]
            public bool? IsDefault { get; set; }

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
