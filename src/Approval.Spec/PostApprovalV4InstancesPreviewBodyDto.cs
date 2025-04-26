// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostApprovalV4InstancesPreviewBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>预览审批流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 预览审批流程 请求体
/// <para>在[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)之前，可调用本接口预览审批流程数据。在[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)之后，可调用本接口预览某一审批节点的后续流程数据。</para>
/// <para>接口ID：6995509710095695876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/approval-preview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTM5UjL5ETO14SOxkTN%2fapproval-preview</para>
/// </summary>
public record PostApprovalV4InstancesPreviewBodyDto
{
    /// <summary>
    /// <para>审批定义 Code。获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>**示例值**："7C468A54-8745-2245-9675-08B7C63E7A85"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>用户 ID，ID 类型与查询参数 user_id_type 的取值一致。</para>
    /// <para>- 在创建审批实例之前预览审批流程，此处需要传入审批发起人的用户 ID。</para>
    /// <para>- 在创建审批实例之后预览某审批任务的后续流程，此处需要传入审批任务审批人 ID。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批发起人所属的部门 ID。了解更多参见[部门 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview#9c02ed7a)。</para>
    /// <para>**注意**：如果用户只属于一个部门，该参数选填。如果用户属于多个部门，则必须填其中一个部门 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>审批表单的控件 JSON 值。</para>
    /// <para>**注意**：在创建审批实例之前预览审批流程，该参数必填。</para>
    /// <para>**示例值**：[{\"id\":\"widget16256287451710001\", \"type\": \"number\", \"value\":\"43\"}]</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string? Form { get; set; }

    /// <summary>
    /// <para>审批实例 Code。获取方式：</para>
    /// <para>- [创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create) 后，从返回结果中获取审批实例 Code。</para>
    /// <para>- 调用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)，获取指定审批定义内的审批实例 Code。</para>
    /// <para>- 调用[查询实例列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/query)，设置过滤条件查询指定的审批实例 Code。</para>
    /// <para>**示例值**："81D31358-93AF-92D6-7425-01A5D67C4E71"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批任务 ID。获取方式：</para>
    /// <para>- 调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)接口，在响应结果的 task_list 参数内获取 id。</para>
    /// <para>- 调用[查询任务列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/search)接口，在响应结果中获取 task_id。</para>
    /// <para>**注意**：在创建审批实例之后预览某审批任务的后续流程，该参数必填，并且 user_id 需要传入任务的审批人 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
