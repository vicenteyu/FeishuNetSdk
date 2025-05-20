// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApprovalV4ExternalTasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取三方审批任务状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 获取三方审批任务状态 响应体
/// <para>该接口用于获取三方审批的状态。用户传入查询条件，接口返回满足条件的审批实例的状态。</para>
/// <para>## 提示</para>
/// <para>该接口支持多种参数的组合，具体请参考请求体示例：</para>
/// <para>- 通过 instance_ids 获取指定实例的任务状态</para>
/// <para>- 通过 user_ids 获取指定用户的任务状态</para>
/// <para>- 通过 status 获取指定状态的所有任务</para>
/// <para>- 通过page_token获取下一批数据</para>
/// <para>接口ID：7117964632137170947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_task%2flist</para>
/// </summary>
public record GetApprovalV4ExternalTasksResponseDto : IPageableResponse<GetApprovalV4ExternalTasksResponseDto.ExternalTaskList>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public ExternalTaskList[]? Items => Datas;

    /// <summary>
    /// <para>返回数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("data")]
    public ExternalTaskList[]? Datas { get; set; }

    /// <summary>
    /// <para>返回数据</para>
    /// </summary>
    public record ExternalTaskList
    {
        /// <summary>
        /// <para>审批实例 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：29075</para>
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批的id</para>
        /// <para>必填：是</para>
        /// <para>示例值：fwwweffff33111133xxx</para>
        /// </summary>
        [JsonPropertyName("approval_id")]
        public string ApprovalId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批对应的 approval_code</para>
        /// <para>必填：是</para>
        /// <para>示例值：B7B65FFE-C2GC-452F-9F0F-9AA8352363D6</para>
        /// </summary>
        [JsonPropertyName("approval_code")]
        public string ApprovalCode { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例当前的状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：PENDING</para>
        /// <para>可选值：<list type="bullet">
        /// <item>PENDING：审批中</item>
        /// <item>APPROVED：审批流程结束，结果为同意</item>
        /// <item>REJECTED：审批流程结束，结果为拒绝</item>
        /// <item>CANCELED：审批发起人撤回</item>
        /// <item>DELETED：审批被删除</item>
        /// <item>HIDDEN：状态隐藏(不显示状态)</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例最后更新时间，单位 毫秒</para>
        /// <para>必填：是</para>
        /// <para>示例值：1621863215000</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例下的审批任务</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tasks")]
        public ExternalTaskItem[]? Tasks { get; set; }

        /// <summary>
        /// <para>审批实例下的审批任务</para>
        /// </summary>
        public record ExternalTaskItem
        {
            /// <summary>
            /// <para>审批任务 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：310</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>审批任务状态</para>
            /// <para>必填：是</para>
            /// <para>示例值：PENDING</para>
            /// <para>可选值：<list type="bullet">
            /// <item>PENDING：审批中</item>
            /// <item>APPROVED：审批流程结束，结果为同意</item>
            /// <item>REJECTED：审批流程结束，结果为拒绝</item>
            /// <item>TRANSFERRED：任务转交</item>
            /// <item>DONE：任务通过但审批人未操作；审批人看不到这个任务, 若想要看到, 可以通过抄送该人.</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("status")]
            public string Status { get; set; } = string.Empty;

            /// <summary>
            /// <para>审批任务最后更新时间，单位 毫秒</para>
            /// <para>必填：是</para>
            /// <para>示例值：1621863215000</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string UpdateTime { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU</para>
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
}
