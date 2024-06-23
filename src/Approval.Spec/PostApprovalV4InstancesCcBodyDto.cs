// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesCcBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>抄送审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 抄送审批实例 请求体
/// <para>通过接口可以将当前审批实例抄送给其他人。</para>
/// <para>接口ID：7114621541589745667</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcc</para>
/// </summary>
public record PostApprovalV4InstancesCcBodyDto
{
    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>**示例值**："7C468A54-8745-2245-9675-08B7C63E7A85"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>**示例值**："7C468A54-8745-2245-9675-08B7C63E7A85"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>根据user_id_type填写发起抄送的人的用户id</para>
    /// <para>**示例值**："f7cb567e"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>根据user_id_type填写被抄送人的 用户id 列表</para>
    /// <para>**示例值**：f7cb567e</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("cc_user_ids")]
    public string[] CcUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>抄送留言</para>
    /// <para>**示例值**："ok"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
