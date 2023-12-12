namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出参会人明细 请求体
/// <para>导出某个会议的参会人详情列表，具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7124195547444477980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/participant_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fparticipant_list</para>
/// </summary>
public record PostVcV1ExportsParticipantListBodyDto
{
    /// <summary>
    /// <para>会议开始时间（需要精确到一分钟，unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonPropertyName("meeting_start_time")]
    public string MeetingStartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议结束时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonPropertyName("meeting_end_time")]
    public string MeetingEndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议状态（不传默认为已结束会议）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：进行中</item>
    /// <item>2：已结束</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("meeting_status")]
    public int? MeetingStatus { get; set; }

    /// <summary>
    /// <para>9位会议号</para>
    /// <para>必填：是</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonPropertyName("meeting_no")]
    public string MeetingNo { get; set; } = string.Empty;

    /// <summary>
    /// <para>按参会Lark用户筛选（最多一个筛选条件）</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>按参会Rooms筛选（最多一个筛选条件）</para>
    /// <para>必填：否</para>
    /// <para>示例值：omm_eada1d61a550955240c28757e7dec3af</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }
}
