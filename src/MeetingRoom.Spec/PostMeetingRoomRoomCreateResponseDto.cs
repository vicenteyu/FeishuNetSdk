namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 创建会议室 响应体
/// <para>该接口用于创建会议室。</para>
/// <para>接口ID：6907569523177799681</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITNwYjLyUDM24iM1AjN</para>
/// </summary>
public record PostMeetingRoomRoomCreateResponseDto
{
    /// <summary>
    /// <para>成功创建的会议室ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }
}
