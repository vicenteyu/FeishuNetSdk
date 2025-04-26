// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalV4InstancesSearchCcBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询抄送列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 查询抄送列表 请求体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批抄送列表。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口查询结果可能存在延迟，无法保证实时性。</para>
/// <para>- 查询时：</para>
/// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
/// <para>- approval_code 和 group_external_id 查询结果取并集；instance_code 和 instance_external_id 查询结果取并集；其他查询条件之间均取交集。</para>
/// <para>接口ID：7117964632137187331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search_cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fsearch_cc</para>
/// </summary>
public record PostApprovalV4InstancesSearchCcBodyDto
{
    /// <summary>
    /// <para>用户 ID，ID 类型与查询参数 user_id_type 保持一致。</para>
    /// <para>必填：否</para>
    /// <para>示例值：lwiu098wj</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批定义 Code。获取方式：</para>
    /// <para>- 调用[创建审批定义](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/create)接口后，从响应参数 approval_code 获取。</para>
    /// <para>- 登录审批管理后台，在指定审批定义的 URL 中获取，具体操作参见[什么是 Approval Code](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/overview-of-approval-resources#8151e0ae)。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- approval_code 和 group_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED942</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 Code。获取方式：</para>
    /// <para>- 调用[创建审批实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/create)接口后，从响应参数 instance_code 获取。</para>
    /// <para>- 调用[批量获取审批实例 ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)接口，获取所需的审批实例 Code。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- instance_code 和 instance_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例的第三方 ID。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- instance_code 和 instance_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED976</para>
    /// </summary>
    [JsonPropertyName("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组的第三方 ID。</para>
    /// <para>**注意**：</para>
    /// <para>- user_id、approval_code、instance_code、instance_external_id、group_external_id 不能同时为空。</para>
    /// <para>- approval_code 和 group_external_id 查询结果取并集。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234567</para>
    /// </summary>
    [JsonPropertyName("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批抄送标题。</para>
    /// <para>**说明**：仅第三方审批存在审批抄送标题。</para>
    /// <para>必填：否</para>
    /// <para>示例值：test</para>
    /// </summary>
    [JsonPropertyName("cc_title")]
    public string? CcTitle { get; set; }

    /// <summary>
    /// <para>审批抄送状态。</para>
    /// <para>**注意**：若不设置则查询全部状态，若不在集合中，则报错。</para>
    /// <para>必填：否</para>
    /// <para>示例值：read</para>
    /// <para>可选值：<list type="bullet">
    /// <item>READ：已读</item>
    /// <item>UNREAD：未读</item>
    /// <item>ALL：所有状态</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("read_status")]
    public string? ReadStatus { get; set; }

    /// <summary>
    /// <para>抄送查询开始时间，Unix 毫秒时间戳。与 cc_create_time_from 参数构成时间段查询条件，仅会返回在该时间段内的审批抄送。</para>
    /// <para>**注意**：查询时间跨度不得大于 30 天，开始和结束时间必须同时设置或者同时不设置。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("cc_create_time_from")]
    public string? CcCreateTimeFrom { get; set; }

    /// <summary>
    /// <para>抄送查询结束时间，Unix 毫秒时间戳。与 cc_create_time_from 参数构成时间段查询条件，仅会返回在该时间段内的审批抄送。</para>
    /// <para>**注意**：查询时间跨度不得大于 30 天，开始和结束时间必须同时设置或者同时不设置。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("cc_create_time_to")]
    public string? CcCreateTimeTo { get; set; }

    /// <summary>
    /// <para>语言</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh-CN</para>
    /// <para>可选值：<list type="bullet">
    /// <item>zh-CN：中文</item>
    /// <item>en-US：英文</item>
    /// <item>ja-JP：日文</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }
}
