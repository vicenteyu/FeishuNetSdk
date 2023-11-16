namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 更新会议室 请求体
/// <para>该接口用于更新会议室。</para>
/// <para>接口ID：6907569524100694017</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/update-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMTNwYjLzUDM24yM1AjN</para>
/// </summary>
public record PostMeetingRoomRoomUpdateBodyDto
{
    /// <summary>
    /// <para>要更新的会议室ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string RoomId { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议室名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>容量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>
    /// <para>租户自定义会议室ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_room_id")]
    public string? CustomRoomId { get; set; }
}
