namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 删除会议室 请求体
/// <para>该接口用于删除会议室。</para>
/// <para>接口ID：6907569523177750529</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/delete-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUzMxYjL1MTM24SNzEjN</para>
/// </summary>
public record PostMeetingRoomRoomDeleteBodyDto
{
    /// <summary>
    /// <para>要删除的会议室ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string RoomId { get; set; } = string.Empty;
}
