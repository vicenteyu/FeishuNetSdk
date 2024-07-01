// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1OffboardingsSubmitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>操作员工离职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 操作员工离职 响应体
/// <para>该接口用于发起员工离职，相当于人事系统员工的直接离职功能。若发起成功，会生成一条员工的离职数据，同时产生相应的事件。参考[离职申请状态变更（新）](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/status_updated)和[离职流转状态变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/checklist_updated)</para>
/// <para>接口ID：7097044451155214340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsubmit</para>
/// </summary>
public record PostCorehrV1OffboardingsSubmitResponseDto
{
    /// <summary>
    /// <para>离职记录 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7095671727698478604</para>
    /// </summary>
    [JsonPropertyName("offboarding_id")]
    public string? OffboardingId { get; set; }

    /// <summary>
    /// <para>雇员 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>离职原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：reason_for_offboarding_option8</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_unique_identifier")]
    public string? OffboardingReasonUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>离职日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-18</para>
    /// </summary>
    [JsonPropertyName("offboarding_date")]
    public string? OffboardingDate { get; set; }

    /// <summary>
    /// <para>离职原因说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：离职原因说明</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_explanation")]
    public string? OffboardingReasonExplanation { get; set; }

    /// <summary>
    /// <para>是否加入离职屏蔽名单</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("add_block_list")]
    public bool? AddBlockList { get; set; }

    /// <summary>
    /// <para>屏蔽原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：红线</para>
    /// </summary>
    [JsonPropertyName("block_reason")]
    public string? BlockReason { get; set; }

    /// <summary>
    /// <para>屏蔽原因说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：xx 年 xx 月 xx 日因 xx 原因红线</para>
    /// </summary>
    [JsonPropertyName("block_reason_explanation")]
    public string? BlockReasonExplanation { get; set; }

    /// <summary>
    /// <para>创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-09 17:50:17</para>
    /// </summary>
    [JsonPropertyName("created_time")]
    public string? CreatedTime { get; set; }
}
