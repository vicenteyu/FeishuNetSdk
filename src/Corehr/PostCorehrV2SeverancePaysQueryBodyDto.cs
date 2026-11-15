// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="PostCorehrV2SeverancePaysQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索被动解除补偿金信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索被动解除补偿金信息 请求体
/// <para>该接口用于按员工、补偿金记录 ID、状态、测算状态、时间范围和返回字段搜索被动解除补偿金记录。</para>
/// <para>接口ID：7667872540325727194</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fquery</para>
/// </summary>
public record PostCorehrV2SeverancePaysQueryBodyDto
{
    /// <summary>
    /// <para>员工雇佣ID列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>补偿金业务单ID列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("severance_pay_ids")]
    public string[]? SeverancePayIds { get; set; }

    /// <summary>
    /// <para>补偿金状态过滤</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>approving：审批中</item>
    /// <item>approved：审批通过</item>
    /// <item>rejected：已拒绝</item>
    /// <item>withdrawn：已撤销</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("statuses")]
    public string[]? Statuses { get; set; }

    /// <summary>
    /// <para>测算状态过滤</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>invalid：已失效</item>
    /// <item>success：测算成功</item>
    /// <item>in_progress：测算中</item>
    /// <item>anti_begin：未测试</item>
    /// <item>interrupted：已停止</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("calculate_statuses")]
    public string[]? CalculateStatuses { get; set; }

    /// <summary>
    /// <para>申请发起时间起，Unix 秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783994400</para>
    /// <para>最大长度：19</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("apply_initiating_time_start")]
    public string? ApplyInitiatingTimeStart { get; set; }

    /// <summary>
    /// <para>申请发起时间止，Unix 秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783994400</para>
    /// <para>最大长度：19</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("apply_initiating_time_end")]
    public string? ApplyInitiatingTimeEnd { get; set; }

    /// <summary>
    /// <para>离职日期起</para>
    /// <para>必填：否</para>
    /// <para>示例值：2026-08-26</para>
    /// </summary>
    [JsonPropertyName("offboarding_date_start")]
    public string? OffboardingDateStart { get; set; }

    /// <summary>
    /// <para>离职日期止</para>
    /// <para>必填：否</para>
    /// <para>示例值：2026-08-26</para>
    /// </summary>
    [JsonPropertyName("offboarding_date_end")]
    public string? OffboardingDateEnd { get; set; }

    /// <summary>
    /// <para>指定返回字段</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("select_fields")]
    public string[]? SelectFields { get; set; }
}
