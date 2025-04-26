// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostApprovalV4TasksRejectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>拒绝审批任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 拒绝审批任务 请求体
/// <para>对于单个审批任务进行拒绝操作。拒绝后审批流程结束。</para>
/// <para>接口ID：7114621541589762051</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/reject</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2freject</para>
/// </summary>
public record PostApprovalV4TasksRejectBodyDto
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
    /// <para>- 调用[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)接口后，从响应参数 instance_code 获取。</para>
    /// <para>- 调用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)接口，获取所需的审批实例 Code。</para>
    /// <para>- 调用[查询实例列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/query)，设置过滤条件查询指定的审批实例 Code。</para>
    /// <para>必填：是</para>
    /// <para>示例值：81D31358-93AF-92D6-7425-01A5D67C4E71</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string InstanceCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批人的用户 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批意见</para>
    /// <para>必填：否</para>
    /// <para>示例值：OK</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>审批任务 ID，调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)，从返回结果的 task_list 中获取所需的 id。</para>
    /// <para>必填：是</para>
    /// <para>示例值：12345</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>如果审批定义的流程设计中添加了条件分支，则需要传入条件分支所需的控件数据（JSON 数组），否则会影响后续的分支条件流转。</para>
    /// <para>**说明**：传值时需要将 JSON 序列化为字符串。参数示例值未进行转义，正确的传值示例可参见下文 **请求体示例**。</para>
    /// <para>必填：否</para>
    /// <para>示例值：[{\"id\":\"user_name\", \"type\": \"input\", \"value\":\"test\"}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string? Form { get; set; }
}
