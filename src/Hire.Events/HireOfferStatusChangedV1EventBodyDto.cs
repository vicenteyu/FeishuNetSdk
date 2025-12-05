// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireOfferStatusChangedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Offer 状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// Offer 状态变更 事件体
/// <para>当 Offer 状态发生变更时发送该事件。除 Offer 创建时不会发送以外，其它 Offer 状态变更均会发送事件，Offer 状态变更场景可参考「Offer 状态流转图」。注意：仅推送正式 Offer 的状态变更信息，实习 Offer 相关状态不推送。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=offer&amp;event=status_changed)</para>
/// <para>接口ID：7143809848869683203</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/events/status_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fevents%2fstatus_changed</para>
/// </summary>
public record HireOfferStatusChangedV1EventBodyDto() : EventBodyDto("hire.offer.status_changed_v1")
{
    /// <summary>
    /// <para>发生状态变更的 OfferID，可通过[获取 Offer 详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer/get)接口获取 Offer 详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offer_id")]
    public string? OfferId { get; set; }
}
