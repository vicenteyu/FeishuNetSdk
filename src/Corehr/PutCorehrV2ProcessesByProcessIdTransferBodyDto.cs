// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PutCorehrV2ProcessesByProcessIdTransferBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转交审批任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 转交审批任务 请求体
/// <para>对于单个审批任务进行转交操作。转交后审批流程流转给被转交人。</para>
/// <para>接口ID：7431073872102883356</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-transfer/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-transfer%2fupdate</para>
/// </summary>
public record PutCorehrV2ProcessesByProcessIdTransferBodyDto
{
    /// <summary>
    /// <para>操作人，按user_id_type类型传递；如果system_user为true，则此字段可以不填</para>
    /// <para>必填：否</para>
    /// <para>示例值：7184703091806602796</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// <para>被转交人，按user_id_type类型传递</para>
    /// <para>必填：是</para>
    /// <para>示例值：7184703091806602796</para>
    /// </summary>
    [JsonPropertyName("to_user_id")]
    public string ToUserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>待转交审批任务id列表</para>
    /// <para>同一个审批节点如果有多个审批人，不同审批人的 approver_id 不同。</para>
    /// <para>可通过 [获取单个流程详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)接口获取流程中各审批任务的 approver_id。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("approver_ids")]
    public string[] ApproverIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：备注</para>
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// <para>是否以系统身份操作，如果为fasle，则operator必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("system_user")]
    public bool? SystemUser { get; set; }
}
