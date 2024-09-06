// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApprovalEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批通过通知 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 审批通过通知 事件体
    /// </summary>
    public record ApprovalEventBodyDto() : EventBodyDto("approval")
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("definition_code")]
        public string? DefinitionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("definition_name")]
        public string? DefinitionName { get; set; }

        /// <summary>
        /// 审批结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 审批实例 Code
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string? InstanceCode { get; set; }

        /// <summary>
        /// 审批开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

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
    }
}
