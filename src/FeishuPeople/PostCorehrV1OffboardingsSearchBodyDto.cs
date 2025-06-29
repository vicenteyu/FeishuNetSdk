// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-01-08
// ************************************************************************
// <copyright file="PostCorehrV1OffboardingsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索离职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 搜索离职信息 请求体
/// <para>该接口支持根据员工ID、离职审批发起时间和离职日期等字段搜索离职信息，可获取包括离职日期、离职原因、离职状态和流程审批状态等信息。</para>
/// <para>接口ID：7211423970042183684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsearch</para>
/// </summary>
public record PostCorehrV1OffboardingsSearchBodyDto
{
    /// <summary>
    /// <para>雇佣 ID 列表，ID类型与查询参数 user_id_type取值一致：</para>
    /// <para>- 当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>- 当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>- 当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>- 当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>离职审批发起时间（搜索的起始范围），请按照秒级时间戳格式传入。该字段非必填，需要与离职审批发起时间（搜索的结束范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1672578336</para>
    /// </summary>
    [JsonPropertyName("apply_initiating_time_start")]
    public string? ApplyInitiatingTimeStart { get; set; }

    /// <summary>
    /// <para>离职审批发起时间（搜索的结束范围），请按照秒级时间戳格式传入。该字段非必填，需要与离职审批发起时间（搜索的起始范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1674133537</para>
    /// </summary>
    [JsonPropertyName("apply_initiating_time_end")]
    public string? ApplyInitiatingTimeEnd { get; set; }

    /// <summary>
    /// <para>离职审批结束时间（搜索的起始范围），请按照秒级时间戳格式传入。该字段非必填，需要与离职审批结束时间（搜索的结束范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1641007353</para>
    /// </summary>
    [JsonPropertyName("apply_finished_time_start")]
    public string? ApplyFinishedTimeStart { get; set; }

    /// <summary>
    /// <para>离职审批结束时间 （搜索的结束范围），请按照秒级时间戳格式传入。该字段非必填，需要与离职审批结束时间（搜索的起始范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1641007353</para>
    /// </summary>
    [JsonPropertyName("apply_finished_time_end")]
    public string? ApplyFinishedTimeEnd { get; set; }

    /// <summary>
    /// <para>期望离职日期（搜索的起始范围），请按日期格式传入。该字段非必填，需要与期望离职日期（搜索的结束范围）一同使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("expected_offboarding_date_start")]
    public string? ExpectedOffboardingDateStart { get; set; }

    /// <summary>
    /// <para>期望离职日期（搜索的结束范围），请按日期格式传入。该字段非必填，需要与期望离职日期（搜索的起始范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("expected_offboarding_date_end")]
    public string? ExpectedOffboardingDateEnd { get; set; }

    /// <summary>
    /// <para>离职日期（搜索的起始范围），请按日期格式传入。该字段非必填，需要与离职日期（搜索的结束范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("offboarding_date_start")]
    public string? OffboardingDateStart { get; set; }

    /// <summary>
    /// <para>离职日期（搜索的结束范围），该字段非必填，需要与离职日期（搜索的起始范围）一同使用。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonPropertyName("offboarding_date_end")]
    public string? OffboardingDateEnd { get; set; }

    /// <summary>
    /// <para>离职状态，多个状态之间为「或」的关系。为空时默认搜索所有状态的离职信息。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// <para>可选值：<list type="bullet">
    /// <item>Approving：审批中</item>
    /// <item>Approved：审批通过</item>
    /// <item>Offboarded：已离职</item>
    /// <item>Rejected：已拒绝</item>
    /// <item>Withdrawn：已撤销</item>
    /// <item>NoNeedApproval：无需审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("statuses")]
    public string[]? Statuses { get; set; }

    /// <summary>
    /// <para>离职原因列表 , 可以通过[【查询员工离职原因列表】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/query)接口获取 ，查询时不返回下级原因相关的离职信息。为空时默认搜索所有离职数据。</para>
    /// <para>字段权限要求：</para>
    /// <para>- corehr:employment.offboarding_reason.search:read : 按照离职原因搜索</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reasons")]
    public string[]? Reasons { get; set; }

    /// <summary>
    /// <para>离职原因（员工）列表 , 可以通过[【查询员工离职原因列表】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/query)接口获取，查询时不返回下级原因相关的离职信息。为空时默认搜索所有离职数据。</para>
    /// <para>字段权限要求：</para>
    /// <para>- corehr:employment.offboarding_reason.search:read : 按照离职原因搜索</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employee_reasons")]
    public string[]? EmployeeReasons { get; set; }
}
