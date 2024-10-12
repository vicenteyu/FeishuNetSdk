// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-27
//
// Last Modified By : yxr
// Last Modified On : 2024-09-27
// ************************************************************************
// <copyright file="GetCorehrV2ApproversResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指定人员审批任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取指定人员审批任务列表 响应体
/// <para>审批任务依赖于流程节点实例存在，每一个流程节点实例可能包含有一或多个审批任务，每一个任务表明当前节点的审批人是谁，该接口可获取指定人员的审批任务列表。</para>
/// <para>接口ID：7419213540896423940</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process_approver/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_approver%2flist</para>
/// </summary>
public record GetCorehrV2ApproversResponseDto
{
    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>审批任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approvers")]
    public ApproverInfo[]? Approvers { get; set; }

    /// <summary>
    /// <para>审批任务列表</para>
    /// </summary>
    public record ApproverInfo
    {
        /// <summary>
        /// <para>审批任务id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7410781046418966060</para>
        /// </summary>
        [JsonPropertyName("approver_id")]
        public string? ApproverId { get; set; }

        /// <summary>
        /// <para>流程id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7410781046418966060</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>任务状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>-2：跳过</item>
        /// <item>-1：发起</item>
        /// <item>0：未开始</item>
        /// <item>1：进行中</item>
        /// <item>2：已拒绝</item>
        /// <item>3：已通过</item>
        /// <item>4：被撤回</item>
        /// <item>5：抄送</item>
        /// <item>6：表单提交</item>
        /// <item>12：失败</item>
        /// <item>14：已回退</item>
        /// <item>16：发起撤销</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("approver_status")]
        public int? ApproverStatus { get; set; }
    }
}
