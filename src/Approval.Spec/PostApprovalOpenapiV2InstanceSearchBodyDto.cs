// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV2InstanceSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>实例列表查询 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 实例列表查询 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/query)该接口通过不同条件查询审批系统中符合条件的审批实例列表。</para>
/// <para>接口ID：6907568073251946498</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/instance-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMxYjL0ITM24CNyEjN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceSearchBodyDto
{
    /// <summary>
    /// <para>用户 id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例第三方 id</para>
    /// <para>注：和 approval_code 取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组第三方 id</para>
    /// <para>注：和 instance_code 取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批实例标题（只有第三方审批有）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_title")]
    public string? InstanceTitle { get; set; }

    /// <summary>
    /// <para>审批实例状态</para>
    /// <para>REJECT：拒绝</para>
    /// <para>PENDING：审批中</para>
    /// <para>RECALL：撤回</para>
    /// <para>DELETED： 已删除</para>
    /// <para>APPROVED：通过</para>
    /// <para>注：若不设置，查询全部状态</para>
    /// <para>若不在集合中，报错</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_status")]
    public string? InstanceStatus { get; set; }

    /// <summary>
    /// <para>实例查询开始时间（unix毫秒时间戳）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_start_time_from")]
    public long? InstanceStartTimeFrom { get; set; }

    /// <summary>
    /// <para>实例查询结束时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("instance_start_time_to")]
    public long? InstanceStartTimeTo { get; set; }

    /// <summary>
    /// <para>地区 （zh-CN、en-US、ja-JP）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>查询偏移量</para>
    /// <para>注：不得超过10000</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>查询限制量</para>
    /// <para>注：不得超过200</para>
    /// <para>不设置默认查询10条数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}
