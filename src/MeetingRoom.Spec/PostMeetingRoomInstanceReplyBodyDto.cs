namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 回复会议室日程实例 请求体
/// <para>调用该接口用于回复会议室日程实例，支持回复未签到释放、提前结束释放、被管理员置为接受、被管理员置为拒绝。</para>
/// <para>**说明**：你可以先调用[查询会议室忙闲](https://open.feishu.cn/document/ukTMukTMukTM/uIDOyUjLygjM14iM4ITN)接口，获取指定会议室的某一日程的 uid、original_time 信息，然后再调用本接口回复会议室日程。&lt;BR&gt;</para>
/// <para>**ID说明**：日程 ID（event_id）格式为 `&lt;Uid&gt;_&lt;Original time&gt;`，因此你可以通过 event_id 获取日程的 Uid 和 Original time。例如，日程 ID 为 `c32537e6-e0a8-4506-b42f-47440655cdb4_0` ，则 Uid 为 `c32537e6-e0a8-4506-b42f-47440655cdb4`、Original time 为 `0`。</para>
/// <para>接口ID：6907569745299226626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/reply-meeting-room-event-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYzN4UjL2cDO14iN3gTN</para>
/// </summary>
public record PostMeetingRoomInstanceReplyBodyDto
{
    /// <summary>
    /// <para>会议室 ID。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string RoomId { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议室对应的日程 Uid。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("uid")]
    public string Uid { get; set; } = string.Empty;

    /// <summary>
    /// <para>日程实例原始时间。非重复性日程和重复性日程，此处传 0；重复性日程的例外日程，此处传对应的 original_time 值（时间戳类型）。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("original_time")]
    public int OriginalTime { get; set; }

    /// <summary>
    /// <para>回复状态。</para>
    /// <para>**可选值有：**</para>
    /// <para>- NOT_CHECK_IN：未签到</para>
    /// <para>- ENDED_BEFORE_DUE：提前结束</para>
    /// <para>- ACCEPTED_BY_ADMIN：被管理员置为接受</para>
    /// <para>DECLINED_BY_ADMIN：被管理员置为拒绝</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
}
