// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesCancelBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤回审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 撤回审批实例 请求体
/// <para>如果管理员在后台设置了 **允许撤销审批中的申请** 或者 **允许撤销 x 天内通过的审批**，则在符合规则时，提交人可以调用该接口撤回审批实例。</para>
/// <para>接口ID：7114621541589843971</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcancel</para>
/// </summary>
public record PostApprovalV4InstancesCancelBodyDto
{
    /// <summary>
    /// <para>审批定义Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例Code</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作用户, 根据user_id_type填写</para>
    /// <para>必填：是</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;
}
