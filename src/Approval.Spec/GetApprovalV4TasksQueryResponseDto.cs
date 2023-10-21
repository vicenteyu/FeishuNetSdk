using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查询用户的任务列表 响应体
/// <para>根据用户和任务分组查询任务列表。</para>
/// <para>接口ID：6986936689592549378</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fquery</para>
/// </summary>
public record GetApprovalV4TasksQueryResponseDto
{
    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tasks")]
    public Task[]? Tasks { get; set; }

    public record Task
    {
        /// <summary>
        /// <para>任务所属的任务分组，如「待办」、「已办」等</para>
        /// <para>**可选值有**：</para>
        /// <para>1:待办审批,2:已办审批,3:已发起审批,17:未读知会,18:已读知会</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：待办审批</item>
        /// <item>2：已办审批</item>
        /// <item>3：已发起审批</item>
        /// <item>17：未读知会</item>
        /// <item>18：已读知会</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// <para>任务所属的用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>任务题目</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>任务相关 URL</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("urls")]
        public TaskUrls? Urls { get; set; }

        public record TaskUrls
        {
            /// <summary>
            /// <para>帮助服务台 URL</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("helpdesk")]
            public string? Helpdesk { get; set; }

            /// <summary>
            /// <para>移动端 URL</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("mobile")]
            public string? Mobile { get; set; }

            /// <summary>
            /// <para>PC 端 URL</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("pc")]
            public string? Pc { get; set; }
        }

        /// <summary>
        /// <para>流程三方 ID，仅第三方流程，需要在当前租户、当前 APP 内唯一</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("process_external_id")]
        public string? ProcessExternalId { get; set; }

        /// <summary>
        /// <para>任务三方 ID，仅第三方流程，需要在当前流程实例内唯一</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("task_external_id")]
        public string? TaskExternalId { get; set; }

        /// <summary>
        /// <para>任务状态</para>
        /// <para>**可选值有**：</para>
        /// <para>1:待办,2:已办,17:未读,18:已读,33:处理中，标记完成用,34:撤回</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：待办</item>
        /// <item>2：已办</item>
        /// <item>17：未读</item>
        /// <item>18：已读</item>
        /// <item>33：处理中，标记完成用</item>
        /// <item>34：撤回</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>流程实例状态</para>
        /// <para>**可选值有**：</para>
        /// <para>0:无流程状态，不展示对应标签,1:流程实例流转中,2:已通过,3:已拒绝,4:已撤销,5:已终止</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：无流程状态，不展示对应标签</item>
        /// <item>1：流程实例流转中</item>
        /// <item>2：已通过</item>
        /// <item>3：已拒绝</item>
        /// <item>4：已撤销</item>
        /// <item>5：已终止</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("process_status")]
        public string? ProcessStatus { get; set; }

        /// <summary>
        /// <para>流程定义 Code</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("definition_code")]
        public string? DefinitionCode { get; set; }

        /// <summary>
        /// <para>发起人 ID 列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("initiators")]
        public string[]? Initiators { get; set; }

        /// <summary>
        /// <para>发起人姓名列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("initiator_names")]
        public string[]? InitiatorNames { get; set; }

        /// <summary>
        /// <para>任务 ID，全局唯一</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>流程 ID，全局唯一</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>流程 Code</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("process_code")]
        public string? ProcessCode { get; set; }

        /// <summary>
        /// <para>流程定义分组 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("definition_group_id")]
        public string? DefinitionGroupId { get; set; }

        /// <summary>
        /// <para>流程定义分组名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("definition_group_name")]
        public string? DefinitionGroupName { get; set; }

        /// <summary>
        /// <para>流程定义 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("definition_id")]
        public string? DefinitionId { get; set; }

        /// <summary>
        /// <para>流程定义名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("definition_name")]
        public string? DefinitionName { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>列表计数，只在分页第一页返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("count")]
    public CountSuffix? Count { get; set; }

    public record CountSuffix
    {
        /// <summary>
        /// <para>总数，大于等于 1000 个项目时将返回 999</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// <para>还有更多，当大于等于 1000 时将返回 true</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("has_more")]
        public bool? HasMore { get; set; }
    }
}
