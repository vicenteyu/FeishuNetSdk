// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="GetApprovalV4TasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询审批任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询审批任务列表 响应体
/// <para>通过设置任务分组、审批定义 Code（审批流程的唯一标识）等，查询任务列表。任务分组包括待办审批、已办审批等</para>
/// <para>接口ID：7642253323628448734</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2flist</para>
/// </summary>
public record GetApprovalV4TasksResponseDto : IPageableResponse<GetApprovalV4TasksResponseDto.UatTask>
{
    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("tasks")]
    public UatTask[] Tasks { get; set; } = [];

    /// <summary>
    /// <para>任务列表</para>
    /// </summary>
    public record UatTask
    {
        /// <summary>
        /// <para>任务所属的任务分组，如「待办」、「已办」等</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：待办</item>
        /// <item>2：已办</item>
        /// <item>3：已发起</item>
        /// <item>17：未读知会</item>
        /// <item>18：已读知会</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("topic")]
        public string Topic { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务所属的用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务题目</para>
        /// <para>必填：是</para>
        /// <para>示例值：审批</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// <para>任务状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：Todo</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：待办</item>
        /// <item>2：已办</item>
        /// <item>17：未读</item>
        /// <item>18：已读</item>
        /// <item>33：处理中，标记完成用</item>
        /// <item>34：撤回</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：Running</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无流程状态，不展示对应标签</item>
        /// <item>1：流程实例流转中</item>
        /// <item>2：已通过</item>
        /// <item>3：已拒绝</item>
        /// <item>4：已撤销</item>
        /// <item>5：已终止</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("instance_status")]
        public string InstanceStatus { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批定义 Code</para>
        /// <para>必填：是</para>
        /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
        /// </summary>
        [JsonPropertyName("definition_code")]
        public string DefinitionCode { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起人 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("initiator")]
        public string? Initiator { get; set; }

        /// <summary>
        /// <para>发起人姓名</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("initiator_name")]
        public string? InitiatorName { get; set; }

        /// <summary>
        /// <para>任务 ID，全局唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例 Code</para>
        /// <para>必填：是</para>
        /// <para>示例值：ABC</para>
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string InstanceCode { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批定义分组 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("definition_group_id")]
        public string? DefinitionGroupId { get; set; }

        /// <summary>
        /// <para>审批定义分组名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：加班</para>
        /// </summary>
        [JsonPropertyName("definition_group_name")]
        public string? DefinitionGroupName { get; set; }

        /// <summary>
        /// <para>审批定义名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：加班</para>
        /// </summary>
        [JsonPropertyName("definition_name")]
        public string? DefinitionName { get; set; }

        /// <summary>
        /// <para>摘要</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("summaries")]
        public Pair[]? Summaries { get; set; }

        /// <summary>
        /// <para>摘要</para>
        /// </summary>
        public record Pair
        {
            /// <summary>
            /// <para>字段key</para>
            /// <para>必填：否</para>
            /// <para>示例值：key</para>
            /// </summary>
            [JsonPropertyName("key")]
            public string? Key { get; set; }

            /// <summary>
            /// <para>字段value</para>
            /// <para>必填：否</para>
            /// <para>示例值：value</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }
        }

        /// <summary>
        /// <para>三方审批实例 ID，仅第三方审批实例存在该字段，需要在当前租户、当前 APP 内唯一</para>
        /// <para>必填：否</para>
        /// <para>示例值：example_instance_id</para>
        /// </summary>
        [JsonPropertyName("instance_external_id")]
        public string? InstanceExternalId { get; set; }

        /// <summary>
        /// <para>三方任务 ID，仅第三方审批任务存在该字段，需要在当前审批实例内唯一</para>
        /// <para>必填：否</para>
        /// <para>示例值：example_task_id</para>
        /// </summary>
        [JsonPropertyName("task_external_id")]
        public string? TaskExternalId { get; set; }

        /// <summary>
        /// <para>是否支持通过api接口同意或拒绝任务</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("support_api_operate")]
        public bool? SupportApiOperate { get; set; }

        /// <summary>
        /// <para>三方审批跳转链接，用于跳转回三方审批系统查看单据详情</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.xxxx.com</para>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：example_page_token</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>列表计数，只在分页第一页返回，大于等于 100 个任务时将返回 99</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>最大值：999</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <inheritdoc/>
    public UatTask[]? Items => Tasks;
}
