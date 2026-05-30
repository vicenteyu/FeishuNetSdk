// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="PostVcV1MeetingsSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>订阅会议变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 订阅会议变更事件 请求体
/// <para>订阅当前用户身份相关的会议资源变更事件。通过指定事件类型，来订阅会议资源不同的事件变更。</para>
/// <para>接口ID：7644841241633967051</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fsubscription</para>
/// </summary>
public record PostVcV1MeetingsSubscriptionBodyDto
{
    /// <summary>
    /// <para>事件类型</para>
    /// <para>**可选值有:**</para>
    /// <para>- `vc.meeting.participant_meeting_ended_v1`: 参与的会议结束事件</para>
    /// <para>必填：否</para>
    /// <para>示例值：vc.meeting.participant_meeting_ended_v1</para>
    /// </summary>
    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }
}
