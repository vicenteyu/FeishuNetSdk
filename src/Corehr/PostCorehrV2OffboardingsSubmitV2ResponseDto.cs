// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-15
//
// Last Modified By : yxr
// Last Modified On : 2024-11-15
// ************************************************************************
// <copyright file="PostCorehrV2OffboardingsSubmitV2ResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>操作员工离职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 操作员工离职 响应体
/// <para>该接口用于发起飞书人事的[离职信息](https://people.feishu.cn/people/members/dimission/management)，支持填写离职日期、离职原因、屏蔽名单和自定义字段（附件字段除外）等。当接口成功提交后，会产生对应的[离职信息变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/updated)事件。</para>
/// <para>接口ID：7428522865559257091</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/offboarding/submit_v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2foffboarding%2fsubmit_v2</para>
/// </summary>
public record PostCorehrV2OffboardingsSubmitV2ResponseDto
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

    /// <summary>
    /// <para>离职是否保留飞书账号</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("retain_account")]
    public bool? RetainAccount { get; set; }
}
