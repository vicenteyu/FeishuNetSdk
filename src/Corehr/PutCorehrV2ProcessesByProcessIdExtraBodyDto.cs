// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PutCorehrV2ProcessesByProcessIdExtraBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>加签审批任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 加签审批任务 请求体
/// <para>给单个流程中的节点或审批任务加签，加签方式有前加签、并加签、后加签三种。</para>
/// <para>接口ID：7431073872102866972</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/approver-task/update-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-extra%2fupdate</para>
/// </summary>
public record PutCorehrV2ProcessesByProcessIdExtraBodyDto
{
    /// <summary>
    /// <para>操作人，按user_id_type类型传递；如果system_user为true，则此字段可以不填</para>
    /// <para>必填：否</para>
    /// <para>示例值：7184703091806602796</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// <para>流程节点id，与approver_id二选一传入，都传以node_id为准</para>
    /// <para>必填：否</para>
    /// <para>示例值：7414045453433439788</para>
    /// </summary>
    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }

    /// <summary>
    /// <para>标识流程中一个审批节点的一个审批人的审批任务。</para>
    /// <para>同一个审批节点如果有多个审批人，不同审批人的 approver_id 不同。</para>
    /// <para>可通过 [获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)接口获取流程中各审批任务的 approver_id。</para>
    /// <para>与node_id二选一传入，都传以node_id为准</para>
    /// <para>必填：否</para>
    /// <para>示例值：7424452160928106028</para>
    /// </summary>
    [JsonPropertyName("approver_id")]
    public string? ApproverId { get; set; }

    /// <summary>
    /// <para>加签方式</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：前加签</item>
    /// <item>1：并加签</item>
    /// <item>2：后加签</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("extra_type")]
    public int ExtraType { get; set; }

    /// <summary>
    /// <para>多人加签时的审批方式，需要注意当extra_type为并加签时，此处只能选择会签</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：或签</item>
    /// <item>1：会签</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("approval_type")]
    public int? ApprovalType { get; set; }

    /// <summary>
    /// <para>加签人员id列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("extra_user_ids")]
    public string[] ExtraUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：备注</para>
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// <para>是否以系统身份操作，如果为false，则operator必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("system_user")]
    public bool? SystemUser { get; set; }
}
