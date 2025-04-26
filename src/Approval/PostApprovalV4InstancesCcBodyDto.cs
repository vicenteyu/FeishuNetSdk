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
namespace FeishuNetSdk.Approval;
/// <summary>
/// 抄送审批实例 请求体
/// <para>调用该接口将当前审批实例抄送给指定用户。被抄送的用户可以查看审批实例详情。例如，在飞书客户端的 **工作台 &gt; 审批 &gt; 审批中心 &gt; 抄送我** 列表中查看到审批实例。</para>
/// <para>接口ID：7114621541589745667</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcc</para>
/// </summary>
public record PostApprovalV4InstancesCcBodyDto
{
    /// <summary>
    /// <para>审批定义 Code。获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 Code。获取方式：</para>
    /// <para>- [创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create) 后，从返回结果中获取审批实例 Code。</para>
    /// <para>- 调用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)，获取指定审批定义内的审批实例 Code。</para>
    /// <para>- 调用[查询实例列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/query)，设置过滤条件查询指定的审批实例 Code。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起当前操作的用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>抄送人的用户 ID 列表，ID 类型与查询参数 user_id_type 取值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("cc_user_ids")]
    public string[] CcUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>抄送留言</para>
    /// <para>必填：否</para>
    /// <para>示例值：ok</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}
