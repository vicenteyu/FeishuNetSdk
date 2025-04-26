// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4TasksResubmitBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>重新提交审批任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 重新提交审批任务 请求体
/// <para>对于退回到发起人的审批任务进行重新发起操作。发起后审批流程会流转到下一个审批人。</para>
/// <para>接口ID：7127897901158842396</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/task/resubmit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fresubmit</para>
/// </summary>
public record PostApprovalV4TasksResubmitBodyDto
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
    /// <para>操作人 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：f7cb567e</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>意见。JSON 格式，传入时需要压缩转义为字符串。以下示例值未转义，你可参考请求体示例中的示例 comment 进行编辑。</para>
    /// <para>**JSON 内参数说明**：</para>
    /// <para>- text：string 类型，评论文本内容。</para>
    /// <para>- files：Attachment[] 类型，附件信息。</para>
    /// <para>- url：string 类型，附件链接。</para>
    /// <para>- thumbnailURL：string 类型，缩略图链接。</para>
    /// <para>- fileSize：int64 类型，文件大小。</para>
    /// <para>- title：string 类型，标题。</para>
    /// <para>- type：string 类型，附件类型，取值 image 表示图片类型。</para>
    /// <para>**注意**：对于附件，在 PC 端使用 HTTP 资源链接传图片资源可能会导致缩略图异常，建议使用 HTTPS 传资源附件。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"text\":\"评论\"]}</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// <para>任务 ID。你可调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)，从返回结果的 task_list 中获取所需的 id。</para>
    /// <para>必填：是</para>
    /// <para>示例值：12345</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string TaskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批表单控件值，JSON 数组，传值时需要压缩转义为字符串。该参数与[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)中的 form 参数用法一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"id\":\"user_name\", \"type\": \"input\", \"value\":\"test\"}]</para>
    /// </summary>
    [JsonPropertyName("form")]
    public string Form { get; set; } = string.Empty;
}
