// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HelpdeskNotificationApproveV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>推送审核通知 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk.Events;
/// <summary>
/// 推送审核通知 事件体
/// <para>推送审核状态通知事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=helpdesk&amp;version=v1&amp;resource=notification&amp;event=approve)</para>
/// <para>接口ID：6999529163292622850</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/events/approve</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fevents%2fapprove</para>
/// </summary>
public record HelpdeskNotificationApproveV1EventBodyDto() : EventBodyDto("helpdesk.notification.approve_v1")
{
    /// <summary>
    /// <para>推送任务唯一ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("notification_id")]
    public string? NotificationId { get; set; }

    /// <summary>
    /// <para>服务台唯一ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("helpdesk_id")]
    public string? HelpdeskId { get; set; }

    /// <summary>
    /// <para>REJECTED(审核不通过)</para>
    /// <para>APPROVED(审核通过)</para>
    /// <para>CANCELED(取消审核)</para>
    /// <para>DELETED(删除审核)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approve_status")]
    public string? ApproveStatus { get; set; }
}
