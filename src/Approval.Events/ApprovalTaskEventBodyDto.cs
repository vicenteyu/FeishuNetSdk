// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="ApprovalTaskEventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批任务状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events
{
    /// <summary>
    /// 审批任务状态变更 事件体
    /// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/common-event/approval-task-event</para>
    /// </summary>
    public record ApprovalTaskEventBodyDto() : EventBodyDto("approval_task")
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

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
        public long OperateTime { get; set; }

        /// <summary>
        /// 审批任务 ID
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 操作人 ID（当 task 为自动通过类型时，user_id 为空）
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 任务状态
        /// <list type="bullet">
        /// <item>REVERTED - 已还原</item>
        /// <item>PENDING - 进行中</item>
        /// <item>APPROVED - 已通过</item>
        /// <item>REJECTED - 已拒绝</item>
        /// <item>TRANSFERRED - 已转交</item>
        /// <item>ROLLBACK - 已退回</item>
        /// <item>DONE - 已完成</item>
        /// </list>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 节点自定义ID
        /// </summary>
        [JsonPropertyName("custom_key")]
        public string? CustomKey { get; set; }

        /// <summary>
        /// 节点系统生成唯一ID
        /// </summary>
        [JsonPropertyName("def_key")]
        public string? DefKey { get; set; }

        /// <summary>
        /// 扩展数据, 当前只有退回事件才有此字段，rollback_node_ids退回的节点列表，rollback_custom_node_ids用户自定义配置的节点列表
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }
    }
}
