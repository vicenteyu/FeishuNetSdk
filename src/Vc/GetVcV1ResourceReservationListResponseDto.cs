// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVcV1ResourceReservationListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室预定数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室预定数据 响应体
/// <para>查询会议室预定数据，具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7194805625628065795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-room-data/get-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fresource_reservation_list%2fget</para>
/// </summary>
public record GetVcV1ResourceReservationListResponseDto : IPageableResponse<GetVcV1ResourceReservationListResponseDto.RoomMeetingReservation>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public RoomMeetingReservation[]? Items => RoomReservationLists;

    /// <summary>
    /// <para>会议室预定列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_reservation_list")]
    public RoomMeetingReservation[]? RoomReservationLists { get; set; }

    /// <summary>
    /// <para>会议室预定列表</para>
    /// </summary>
    public record RoomMeetingReservation
    {
        /// <summary>
        /// <para>会议室ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_4de32cf10a4358788ff4e09e37ebbf9b</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>会议室名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：VIP Meeting Room</para>
        /// </summary>
        [JsonPropertyName("room_name")]
        public string? RoomName { get; set; }

        /// <summary>
        /// <para>会议标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：飞书邀请的日程</para>
        /// </summary>
        [JsonPropertyName("event_title")]
        public string? EventTitle { get; set; }

        /// <summary>
        /// <para>预定人</para>
        /// <para>必填：否</para>
        /// <para>示例值：kehan</para>
        /// </summary>
        [JsonPropertyName("reserver")]
        public string? Reserver { get; set; }

        /// <summary>
        /// <para>预定人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_1234567(UserID);cli_123123(BotID)</para>
        /// </summary>
        [JsonPropertyName("reserver_user_id")]
        public string? ReserverUserId { get; set; }

        /// <summary>
        /// <para>预定人所属部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：development</para>
        /// </summary>
        [JsonPropertyName("department_of_reserver")]
        public string? DepartmentOfReserver { get; set; }

        /// <summary>
        /// <para>邀约人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("guests_number")]
        public string? GuestsNumber { get; set; }

        /// <summary>
        /// <para>接受人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("accepted_number")]
        public string? AcceptedNumber { get; set; }

        /// <summary>
        /// <para>会议开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.17 21:00:00 (GMT+08:00)</para>
        /// </summary>
        [JsonPropertyName("event_start_time")]
        public string? EventStartTime { get; set; }

        /// <summary>
        /// <para>会议结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.17 22:00:00 (GMT+08:00)</para>
        /// </summary>
        [JsonPropertyName("event_end_time")]
        public string? EventEndTime { get; set; }

        /// <summary>
        /// <para>会议时长</para>
        /// <para>必填：否</para>
        /// <para>示例值：1:00:00</para>
        /// </summary>
        [JsonPropertyName("event_duration")]
        public string? EventDuration { get; set; }

        /// <summary>
        /// <para>会议室预定状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：预定成功</para>
        /// </summary>
        [JsonPropertyName("reservation_status")]
        public string? ReservationStatus { get; set; }

        /// <summary>
        /// <para>签到设备</para>
        /// <para>必填：否</para>
        /// <para>示例值：签到板</para>
        /// </summary>
        [JsonPropertyName("check_in_device")]
        public string? CheckInDevice { get; set; }

        /// <summary>
        /// <para>会议室签到状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：已签到</para>
        /// </summary>
        [JsonPropertyName("room_check_in_status")]
        public string? RoomCheckInStatus { get; set; }

        /// <summary>
        /// <para>会议室签到时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.09 13:35:30 (GMT+08:00)</para>
        /// </summary>
        [JsonPropertyName("check_in_time")]
        public string? CheckInTime { get; set; }

        /// <summary>
        /// <para>是否提前释放</para>
        /// <para>必填：否</para>
        /// <para>示例值：已释放（手动释放）</para>
        /// </summary>
        [JsonPropertyName("is_release_early")]
        public string? IsReleaseEarly { get; set; }

        /// <summary>
        /// <para>释放人</para>
        /// <para>必填：否</para>
        /// <para>示例值：kehan</para>
        /// </summary>
        [JsonPropertyName("releasing_person")]
        public string? ReleasingPerson { get; set; }

        /// <summary>
        /// <para>释放时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022.12.20 11:25:15 (GMT+08:00)</para>
        /// </summary>
        [JsonPropertyName("releasing_time")]
        public string? ReleasingTime { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
