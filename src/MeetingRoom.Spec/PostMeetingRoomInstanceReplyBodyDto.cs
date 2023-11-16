namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 回复会议室日程实例 请求体
/// <para>该接口用于回复会议室日程实例，包括未签到释放和提前结束释放。</para>
/// <para>接口ID：6907569745299226626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/reply-meeting-room-event-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN4UjL2cDO14iN3gTN</para>
/// </summary>
public record PostMeetingRoomInstanceReplyBodyDto
{
    /// <summary>
    /// <para>会议室的 ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string RoomId { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议室的日程 ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("uid")]
    public string Uid { get; set; } = string.Empty;

    /// <summary>
    /// <para>日程实例原始时间，非重复日程必为0。重复日程若为0则表示回复其所有实例，否则表示回复单个实例。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("original_time")]
    public int OriginalTime { get; set; }

    /// <summary>
    /// <para>回复状态，NOT_CHECK_IN 表示未签到，ENDED_BEFORE_DUE 表示提前结束，ACCEPTED_BY_ADMIN 表示被管理员置为接受，DECLINED_BY_ADMIN 表示被管理员置为拒绝</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
}
