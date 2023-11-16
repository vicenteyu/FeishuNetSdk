namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取与会议号关联的会议列表 响应体
/// <para>获取指定时间范围（90天内)会议号关联的会议简要信息列表。</para>
/// <para>接口ID：7013251669786116097</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting/list_by_no</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2flist_by_no</para>
/// </summary>
public record GetVcV1MeetingsListByNoResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：50</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>会议简要信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting_briefs")]
    public Meeting[]? MeetingBriefs { get; set; }

    /// <summary>
    /// <para>会议简要信息列表</para>
    /// </summary>
    public record Meeting
    {
        /// <summary>
        /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411934433028</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>会议主题</para>
        /// <para>必填：否</para>
        /// <para>示例值：mymeeting</para>
        /// </summary>
        [JsonPropertyName("topic")]
        public string? Topic { get; set; }

        /// <summary>
        /// <para>会议链接（飞书用户可通过点击会议链接快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://vc.feishu.cn/j/337736498</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>会议号</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456789</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }
    }
}
