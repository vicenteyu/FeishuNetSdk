namespace FeishuNetSdk.Vc;
/// <summary>
/// 导出会议室预定数据 请求体
/// <para>导出会议室预定数据，具体权限要求请参考「资源介绍」。</para>
/// <para>接口ID：7124195547444510748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/export/resource_reservation_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fexport%2fresource_reservation_list</para>
/// </summary>
public record PostVcV1ExportsResourceReservationListBodyDto
{
    /// <summary>
    /// <para>会议室层级id</para>
    /// <para>必填：是</para>
    /// <para>示例值：omb_57c9cc7d9a81e27e54c8fabfd02759e7</para>
    /// </summary>
    [JsonPropertyName("room_level_id")]
    public string RoomLevelId { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否展示会议主题</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("need_topic")]
    public bool? NeedTopic { get; set; }

    /// <summary>
    /// <para>查询开始时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询结束时间（unix时间，单位sec）</para>
    /// <para>必填：是</para>
    /// <para>示例值：1655276858</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string EndTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>待筛选的会议室id列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：["omm_eada1d61a550955240c28757e7dec3af"]</para>
    /// </summary>
    [JsonPropertyName("room_ids")]
    public string[]? RoomIds { get; set; }

    /// <summary>
    /// <para>若为true表示导出room_ids范围外的会议室，默认为false</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_exclude")]
    public bool? IsExclude { get; set; }
}
