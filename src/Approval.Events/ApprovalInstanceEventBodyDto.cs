// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApprovalInstanceEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批实例状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 审批实例状态变更 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/common-event/approval-instance-event</para>
    /// </summary>
    public record ApprovalInstanceEventBodyDto() : EventBodyDto("approval_instance")
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

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
        /// 事件发生时间
        /// </summary>
        [JsonPropertyName("operate_time")]
        public string? OperateTime { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [JsonPropertyName("instance_operate_time")]
        public string? InstanceOperateTime { get; set; }

        /// <summary>
        /// 实例状态
        /// <list type="bullet">
        /// <item>PENDING - 审批中</item>
        /// <item>APPROVED - 已通过</item>
        /// <item>REJECTED - 已拒绝</item>
        /// <item>CANCELED - 已撤回</item>
        /// <item>DELETED - 已删除</item>
        /// <item>REVERTED - 已撤销</item>
        /// <item>OVERTIME_CLOSE - 超时被关闭</item>
        /// <item>OVERTIME_RECOVER - 超时实例被恢复</item>
        /// </list>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
