// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMeetingRoomRoomBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询会议室详情 响应体
/// <para>该接口用于获取指定会议室的详细信息。</para>
/// <para>接口ID：6907569523177766913</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/query-meeting-room-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDOyUjLxgjM14SM4ITN</para>
/// </summary>
public record GetMeetingRoomRoomBatchGetResponseDto
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
        /// <para>会议室所属建筑物 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("building_id")]
        public string? BuildingId { get; set; }

        /// <summary>
        /// <para>会议室所属建筑物名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("building_name")]
        public string? BuildingName { get; set; }

        /// <summary>
        /// <para>会议室能容纳的人数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>会议室的相关描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>会议室的展示 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display_id")]
        public string? DisplayId { get; set; }

        /// <summary>
        /// <para>会议室所在楼层名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("floor_name")]
        public string? FloorName { get; set; }

        /// <summary>
        /// <para>会议室是否不可用，若会议室不可用，则该值为 true，否则为 false</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_disabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// <para>会议室名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
