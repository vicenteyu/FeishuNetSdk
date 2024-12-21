// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1ApprovalInstancesByApprovalInstanceIdCancelBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 撤销人工任务 请求体
/// <para>撤销一个人工任务（包括审批任务，填写任务）</para>
/// <para>接口ID：7446337145820364804</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/approval_instance/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapproval_instance%2fcancel</para>
/// </summary>
public record PostApaasV1ApprovalInstancesByApprovalInstanceIdCancelBodyDto
{
    /// <summary>
    /// <para>操作用户的kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>撤销原因</para>
    /// <para>必填：是</para>
    /// <para>示例值：撤销了</para>
    /// </summary>
    [JsonPropertyName("opinion")]
    public string Opinion { get; set; } = string.Empty;
}
