// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="GetApprovalV4InstancesInitiatedResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询用户的已发起审批列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询用户的已发起审批列表 响应体
/// <para>以用户身份获取用户已发起的审批列表，与飞书中审批-&gt;审批中心-&gt;已发起一致</para>
/// <para>接口ID：7642253323628366814</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/initiated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2finitiated</para>
/// </summary>
public record GetApprovalV4InstancesInitiatedResponseDto : IPageableResponse<GetApprovalV4InstancesInitiatedResponseDto.UatInstance>
{
    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("instances")]
    public UatInstance[] Instances { get; set; } = [];

    /// <summary>
    /// <para>任务列表</para>
    /// </summary>
    public record UatInstance
    {
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
        /// <para>审批实例 Code</para>
        /// <para>必填：是</para>
        /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
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
        /// <para>示例值：考勤</para>
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
    public UatInstance[]? Items => Instances;
}
