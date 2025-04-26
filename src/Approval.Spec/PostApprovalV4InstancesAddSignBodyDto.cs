// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesAddSignBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批任务加签 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 审批任务加签 请求体
/// <para>对于单个审批任务进行加签操作。</para>
/// <para>接口ID：6968270299335606273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/approval-task-addsign</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-task-addsign</para>
/// </summary>
public record PostApprovalV4InstancesAddSignBodyDto
{
    /// <summary>
    /// <para>审批定义 Code 获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例 Code 获取方式：</para>
    /// <para>- 调用[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)接口后，从响应参数 instance_code 获取。</para>
    /// <para>- 调用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)接口，获取所需的审批实例 Code。</para>
    /// <para>- 调用[查询实例列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/query)，设置过滤条件查询指定的审批实例 Code。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>操作用户的 user_id，获取方式参考[如何获取 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批任务 ID，调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)，从返回结果的 task_list 中获取所需的 id。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审核意见</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>被加签人的 user_id，可以指定多个。获取方式参考[如何获取 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("add_sign_user_ids")]
    public string[] AddSignUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>加签方式，可选值有：</para>
    /// <para>- 1：前加签，在当前操作用户之前审批。</para>
    /// <para>- 2：后加签，加签后自动通过当前审批，并流转至被加签人。</para>
    /// <para>- 3：并加签，和当前操作用户共同审批。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("add_sign_type")]
    public int AddSignType { get; set; }

    /// <summary>
    /// <para>仅在前加签、后加签时，需要填写该参数。可选值有：</para>
    /// <para>- 1： 或签，一名审批人同意或拒绝即可。</para>
    /// <para>- 2： 会签，需要所有审批人同意或拒绝。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_method")]
    public int? ApprovalMethod { get; set; }
}
