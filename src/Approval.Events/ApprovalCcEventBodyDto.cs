// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApprovalCcEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批抄送状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 审批抄送状态变更 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/common-event/approval-cc-event</para>
    /// </summary>
    public record ApprovalCcEventBodyDto() : EventBodyDto("approval_cc")
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
        [JsonPropertyName("approval_code")]
        public string? ApprovalCode { get; set; }

        /// <summary>
        /// 审批实例 Code
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string? InstanceCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 操作人 ID（当 task 为自动通过类型时，user_id 为空）
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("operate")]
        public string? Operate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("from")]
        public string? From { get; set; }
    }
}
