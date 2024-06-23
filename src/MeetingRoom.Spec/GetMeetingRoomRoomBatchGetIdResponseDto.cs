// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMeetingRoomRoomBatchGetIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询会议室ID 响应体
/// <para>该接口用于根据租户自定义会议室ID查询会议室ID。</para>
/// <para>接口ID：6907569745299767298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-meeting-room-id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzMxYjL2MTM24iNzEjN</para>
/// </summary>
public record GetMeetingRoomRoomBatchGetIdResponseDto
{
    /// <summary>
    /// <para>会议室列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("rooms")]
    public Room[]? Rooms { get; set; }

    /// <summary></summary>
    public record Room
    {
        /// <summary>
        /// <para>会议室 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>租户自定义会议室 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_room_id")]
        public string? CustomRoomId { get; set; }
    }
}
