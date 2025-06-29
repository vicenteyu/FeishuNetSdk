// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-02-21
// ************************************************************************
// <copyright file="PostCorehrV2JobChangesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索员工异动信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工异动信息 请求体
/// <para>搜索异动信息，该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042150916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fsearch</para>
/// </summary>
public record PostCorehrV2JobChangesSearchBodyDto
{
    /// <summary>
    /// <para>雇员 ID 列表，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：30</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>异动记录 ID 列表，可通过接口</para>
    /// <para>[搜索异动信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/search)获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("job_change_ids")]
    public string[]? JobChangeIds { get; set; }

    /// <summary>
    /// <para>异动状态，多个状态之间为「或」的关系</para>
    /// <para>必填：否</para>
    /// <para>示例值：Approved</para>
    /// <para>最大长度：10</para>
    /// <para>可选值：<list type="bullet">
    /// <item>Approving：Approving 审批中</item>
    /// <item>Approved：Approved 审批通过</item>
    /// <item>Transformed：Transformed 已异动</item>
    /// <item>Rejected：Rejected 已拒绝</item>
    /// <item>Cancelled：Cancelled 已撤销</item>
    /// <item>NoNeedApproval：NoNeedApproval 无需审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("statuses")]
    public string[]? Statuses { get; set; }

    /// <summary>
    /// <para>异动生效日期 - 搜索范围开始，需要与搜索范围结束一同使用，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date_start")]
    public string? EffectiveDateStart { get; set; }

    /// <summary>
    /// <para>异动生效日期 - 搜索范围结束，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date_end")]
    public string? EffectiveDateEnd { get; set; }

    /// <summary>
    /// <para>异动更新时间 - 搜索范围开始，需要与搜索范围结束一同使用，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704084635000</para>
    /// </summary>
    [JsonPropertyName("updated_time_start")]
    public string? UpdatedTimeStart { get; set; }

    /// <summary>
    /// <para>异动更新时间 - 搜索范围结束，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1704084635000</para>
    /// </summary>
    [JsonPropertyName("updated_time_end")]
    public string? UpdatedTimeEnd { get; set; }

    /// <summary>
    /// <para>新部门 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：30</para>
    /// </summary>
    [JsonPropertyName("target_department_ids")]
    public string[]? TargetDepartmentIds { get; set; }

    /// <summary>
    /// <para>异动类型，可通过接口</para>
    /// <para>[获取异动类型列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_type/query)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：internal_transfer</para>
    /// <para>最大长度：30</para>
    /// </summary>
    [JsonPropertyName("transfer_type_unique_identifier")]
    public string[]? TransferTypeUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>异动原因，可通过接口</para>
    /// <para>[获取异动原因列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_reason/query)获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：involuntary_transfer</para>
    /// <para>最大长度：30</para>
    /// </summary>
    [JsonPropertyName("transfer_reason_unique_identifier")]
    public string[]? TransferReasonUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>异常处理状态，多个状态之间为「或」的关系</para>
    /// <para>必填：否</para>
    /// <para>示例值：pending</para>
    /// <para>最大长度：10</para>
    /// <para>可选值：<list type="bullet">
    /// <item>pending：pending 未处理</item>
    /// <item>processed：processed 已处理</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("exception_statuses")]
    public string[]? ExceptionStatuses { get; set; }
}
