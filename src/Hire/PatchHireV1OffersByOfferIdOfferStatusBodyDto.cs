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
/// <para>通过 Offer ID 更新候选人 Offer 的「Offer 审批状态」或 「Offer 发送和接受状态」。</para>
/// <para>## 注意事项</para>
/// <para>- 若当前 Offer 是通过飞书招聘发起的审批，则不可通过此接口更新「Offer 审批状态」。</para>
/// <para>- 若当前 Offer 通过飞书招聘发送过候选人，则不可通过此接口更新「Offer 发送和接受状态」。</para>
/// <para>- 若当前 Offer 所属投递阶段已进入「待入职」阶段，则不可通过此接口更新「Offer 审批状态」和「Offer 发送和接受状态」。</para>
/// <para>## 前提条件</para>
/// <para>- 更新 Offer 审批状态前，请前往「飞书招聘」-「设置」-「Offer 设置」-「Offer 规则设置」开启「通过 OA 系统创建和审批 Offer」。</para>
/// <para>- 更新 Offer 发送和接受状态前，请前往「飞书招聘」-「设置」-「Offer 设置」-「Offer 规则设置」开启「通过 OA 系统发送 Offer」。</para>
/// <para>## Offer 状态说明</para>
/// <para>### Offer 状态分类</para>
/// <para>- Offer 被创建后，状态为`「Offer 已创建」`</para>
/// <para>- Offer 审批状态：`「Offer 审批中」`、`「Offer 审批通过」`、`「Offer 审批不通过」`、`「Offer 审批已撤回」`</para>
/// <para>- Offer 发送和接受状态：`「Offer 已发送」`、`「Offer 已失效」`、`「Offer 被候选人接受」`、`「Offer 被候选人拒绝」`</para>
/// <para>### Offer 状态流转图</para>
/// <para>接口ID：7219143467641487363</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/offer_status</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2foffer_status</para>
/// </summary>
public record PatchHireV1OffersByOfferIdOfferStatusBodyDto
{
    /// <summary>
    /// <para>Offer 状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：6</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：Offer 审批中</item>
    /// <item>3：Offer 审批已撤回</item>
    /// <item>4：Offer 审批通过</item>
    /// <item>5：Offer 审批不通过</item>
    /// <item>6：Offer 已发送</item>
    /// <item>7：Offer 被候选人接受</item>
    /// <item>8：Offer 被候选人拒绝</item>
    /// <item>9：Offer 已失效</item>
    /// <item>10：Offer 已创建</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("offer_status")]
    public int OfferStatus { get; set; }

    /// <summary>
    /// <para>Offer 失效时间</para>
    /// <para>**注意**：当请求参数 offer_status 为「Offer 已发送」时必填</para>
    /// <para>**值格式**："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-01-01</para>
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; set; }

    /// <summary>
    /// <para>终止原因 ID 列表，可通过[获取终止投递原因](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/termination_reason/list)接口获取</para>
    /// <para>**最大长度**：</para>
    /// <para>50</para>
    /// <para>**注意**：当请求参数 offer_status 为「Offer 被候选人拒绝」时必填</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("termination_reason_id_list")]
    public string[]? TerminationReasonIdList { get; set; }

    /// <summary>
    /// <para>Offer 终止备注信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：不符合期望</para>
    /// </summary>
    [JsonPropertyName("termination_reason_note")]
    public string? TerminationReasonNote { get; set; }
}
