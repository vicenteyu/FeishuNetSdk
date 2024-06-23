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
/// <para>接口ID：7117964632137187331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search_cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fsearch_cc</para>
/// </summary>
public record PostApprovalV4InstancesSearchCcBodyDto
{
    /// <summary>
    /// <para>根据x_user_type填写用户 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：lwiu098wj</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED942</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED943</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例第三方 id 注：和 approval_code 取并集</para>
    /// <para>必填：否</para>
    /// <para>示例值：EB828003-9FFE-4B3F-AA50-2E199E2ED976</para>
    /// </summary>
    [JsonPropertyName("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组第三方 id 注：和 instance_code 取并集</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234567</para>
    /// </summary>
    [JsonPropertyName("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批抄送标题（只有第三方审批有）</para>
    /// <para>必填：否</para>
    /// <para>示例值：test</para>
    /// </summary>
    [JsonPropertyName("cc_title")]
    public string? CcTitle { get; set; }

    /// <summary>
    /// <para>审批抄送状态，注：若不设置，查询全部状态 若不在集合中，报错</para>
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
    /// <para>抄送查询开始时间（unix毫秒时间戳）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("cc_create_time_from")]
    public string? CcCreateTimeFrom { get; set; }

    /// <summary>
    /// <para>抄送查询结束时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// <para>示例值：1547654251506</para>
    /// </summary>
    [JsonPropertyName("cc_create_time_to")]
    public string? CcCreateTimeTo { get; set; }

    /// <summary>
    /// <para>地区</para>
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
