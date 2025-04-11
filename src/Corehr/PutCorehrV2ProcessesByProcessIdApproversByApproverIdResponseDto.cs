// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="PutCorehrV2ProcessesByProcessIdApproversByApproverIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>通过/拒绝审批任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 通过/拒绝审批任务 响应体
/// <para>对于单个审批任务进行通过（提交）或拒绝操作。对于多人或签节点，一个审批任务通过则整个节点通过；对于多人会签节点，所有审批任务通过则节点通过。在通过（提交）时，若表单中有必填字段，支持写入表单字段。</para>
/// <para>接口ID：7340625370520797187</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/approver-task/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-approver%2fupdate</para>
/// </summary>
public record PutCorehrV2ProcessesByProcessIdApproversByApproverIdResponseDto
{
    /// <summary>
    /// <para>错误码，非 0 表示失败</para>
    /// <para>必填：是</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// <para>错误描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：错误原因</para>
    /// </summary>
    [JsonPropertyName("msg")]
    public string? Msg { get; set; }
}
