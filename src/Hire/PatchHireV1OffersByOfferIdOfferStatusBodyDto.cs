// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchHireV1OffersByOfferIdOfferStatusBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新 Offer 状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新 Offer 状态 请求体
/// <para>通过 Offer ID 更新候选人 Offer 的状态。</para>
/// <para>- 更新 Offer 审批状态，需要在系统内「设置 - Offer 设置 - Offer 规则设置」开启「通过 OA 系统创建和审批 Offer」。如当前 Offer 已通过飞书招聘发起过审批，则不可通过此接口更新 Offer 审批状态</para>
/// <para>- 更新 Offer 发送和接受状态，需要在系统内「设置 - Offer 设置 - Offer 规则设置」开启「通过 OA 系统发送 Offer」；仅支持投递阶段在「待入职」之前更新；如当前 Offer 已通过飞书招聘发给过候选人，则不可通过此接口更新 Offer 发送和接收状态</para>
/// <para>接口ID：7219143467641487363</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/offer_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2foffer_status</para>
/// </summary>
public record PatchHireV1OffersByOfferIdOfferStatusBodyDto
{
    /// <summary>
    /// <para>offer状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：6</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：审批中</item>
    /// <item>3：审批已撤回</item>
    /// <item>4：审批通过</item>
    /// <item>5：审批不通过</item>
    /// <item>6：Offer已发出</item>
    /// <item>7：候选人已接收</item>
    /// <item>8：候选人已拒绝</item>
    /// <item>9：Offer已失效</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("offer_status")]
    public int OfferStatus { get; set; }

    /// <summary>
    /// <para>offer 失效时间，当反馈状态是「offer已发出」时为必填项</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-01-01</para>
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// <para>终止原因列表，当反馈状态是「候选人已拒绝」时为必填项；最多传入50个</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("termination_reason_id_list")]
    public string[]? TerminationReasonIdList { get; set; }

    /// <summary>
    /// <para>终止备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：不符合期望</para>
    /// </summary>
    [JsonPropertyName("termination_reason_note")]
    public string? TerminationReasonNote { get; set; }
}
