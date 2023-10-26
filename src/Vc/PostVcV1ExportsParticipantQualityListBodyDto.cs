using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出参会人会议质量数据 请求体
/// <para>导出某场会议某个参会人的音视频&amp;共享质量数据</para>
/// <para>，具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7124195547444494364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/participant_quality_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fparticipant_quality_list</para>
/// </summary>
public record PostVcV1ExportsParticipantQualityListBodyDto
{
    /// <summary>
    /// <para>会议开始时间（需要精确到一分钟，unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonProperty("meeting_start_time")]
    public string MeetingStartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议结束时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonProperty("meeting_end_time")]
    public string MeetingEndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>9位会议号</para>
    /// <para>必填：是</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonProperty("meeting_no")]
    public string MeetingNo { get; set; } = string.Empty;

    /// <summary>
    /// <para>参会人入会时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonProperty("join_time")]
    public string JoinTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>参会人为Lark用户时填入，room_id和user_id必须只填一个</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>参会人为Rooms时填入，room_id和user_id必须只填一个</para>
    /// <para>必填：否</para>
    /// <para>示例值：omm_eada1d61a550955240c28757e7dec3af</para>
    /// </summary>
    [JsonProperty("room_id")]
    public string? RoomId { get; set; }
}
