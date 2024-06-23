// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchVcV1MeetingsByMeetingIdRecordingStartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>开始录制 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 开始录制 请求体
/// <para>在会议中开始录制。</para>
/// <para>接口ID：6960861158593150980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-recording/start</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting-recording%2fstart</para>
/// </summary>
public record PatchVcV1MeetingsByMeetingIdRecordingStartBodyDto
{
    /// <summary>
    /// <para>录制文件时间显示使用的时区[-12,12]</para>
    /// <para>必填：否</para>
    /// <para>示例值：8</para>
    /// </summary>
    [JsonPropertyName("timezone")]
    public int? Timezone { get; set; }
}
