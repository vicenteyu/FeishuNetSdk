// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="PostVcV1BotsLeaveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>离开会议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 离开会议 请求体
/// <para>机器人可通过会议 ID 主动离开指定的视频会议。调用成功后，将返回该机器人对应的用户信息。</para>
/// <para>接口ID：7672664994766998775</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/leave</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fleave</para>
/// </summary>
public record PostVcV1BotsLeaveBodyDto
{
    /// <summary>
    /// <para>会议唯一标识，用于指定机器人需要退出的目标会议。请传入[加入会议](https://open.feishu.cn/document/server-docs/vc-v1/bot/join)接口调用成功后返回的长数字 `meeting_id`，而不是 9 位会议号。</para>
    /// <para>必填：是</para>
    /// <para>示例值：mtg_202405201430_001</para>
    /// </summary>
    [JsonPropertyName("meeting_id")]
    public string MeetingId { get; set; } = string.Empty;
}
