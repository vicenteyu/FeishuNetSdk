using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 更新预约 响应体
/// <para>更新一个预约。</para>
/// <para>接口ID：6921909217674854427</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fupdate</para>
/// </summary>
public record PutVcV1ReservesByReserveIdResponseDto
{
    /// <summary>
    /// <para>预约数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("reserve")]
    public PutVcV1ReservesByReserveIdResponseDtoReserve? Reserve { get; set; }

    /// <summary>
    /// <para>预约数据</para>
    /// </summary>
    public record PutVcV1ReservesByReserveIdResponseDtoReserve
    {
        /// <summary>
        /// <para>预约ID（预约的唯一标识，非会议ID，会议ID仅在会议开始后才生成）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411934973028</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>9位会议号（飞书用户可通过输入9位会议号快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：112000358</para>
        /// </summary>
        [JsonProperty("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议链接（飞书用户可通过点击会议链接快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://vc.feishu.cn/j/337736498</para>
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>会议转直播链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://meetings.feishu.cn/s/1gub381l4gglv</para>
        /// </summary>
        [JsonProperty("live_link")]
        public string? LiveLink { get; set; }

        /// <summary>
        /// <para>预约到期时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608883322</para>
        /// </summary>
        [JsonProperty("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>过期状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未过期</item>
        /// <item>2：已过期</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("expire_status")]
        public int? ExpireStatus { get; set; }
    }

    /// <summary>
    /// <para>预约参数检查信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("reserve_correction_check_info")]
    public PutVcV1ReservesByReserveIdResponseDtoReserveCorrectionCheckInfo? ReserveCorrectionCheckInfo { get; set; }

    /// <summary>
    /// <para>预约参数检查信息</para>
    /// </summary>
    public record PutVcV1ReservesByReserveIdResponseDtoReserveCorrectionCheckInfo
    {
        /// <summary>
        /// <para>指定主持人无效id列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("invalid_host_id_list")]
        public string[]? InvalidHostIdList { get; set; }
    }
}
