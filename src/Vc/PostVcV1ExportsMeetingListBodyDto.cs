using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出会议明细 请求体
/// <para>导出会议明细，具体权限要求请参考资源介绍。</para>
/// <para>接口ID：7124235806021238785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/meeting_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fmeeting_list</para>
/// </summary>
public record PostVcV1ExportsMeetingListBodyDto
{
    /// <summary>
    /// <para>查询开始时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonProperty("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询结束时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonProperty("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>按9位会议号筛选（最多一个筛选条件）</para>
    /// <para>必填：否</para>
    /// <para>示例值：123456789</para>
    /// </summary>
    [JsonProperty("meeting_no")]
    public string? MeetingNo { get; set; }

    /// <summary>
    /// <para>按参会Lark用户筛选（最多一个筛选条件）</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>按参会Rooms筛选（最多一个筛选条件）</para>
    /// <para>必填：否</para>
    /// <para>示例值：omm_eada1d61a550955240c28757e7dec3af</para>
    /// </summary>
    [JsonProperty("room_id")]
    public string? RoomId { get; set; }
}
