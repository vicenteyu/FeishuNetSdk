// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1ReservesApplyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>预约会议 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 预约会议 响应体
/// <para>创建一个会议预约。</para>
/// <para>接口ID：6960861158129008643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/apply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fapply</para>
/// </summary>
public record PostVcV1ReservesApplyResponseDto
{
    /// <summary>
    /// <para>预约数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reserve")]
    public PostVcV1ReservesApplyResponseDtoReserve? Reserve { get; set; }

    /// <summary>
    /// <para>预约数据</para>
    /// </summary>
    public record PostVcV1ReservesApplyResponseDtoReserve
    {
        /// <summary>
        /// <para>预约ID（预约的唯一标识，非会议ID，会议ID仅在会议开始后才生成）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411934973028</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>9位会议号（飞书用户可通过输入9位会议号快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：112000358</para>
        /// </summary>
        [JsonPropertyName("meeting_no")]
        public string? MeetingNo { get; set; }

        /// <summary>
        /// <para>会议密码</para>
        /// <para>必填：否</para>
        /// <para>示例值：971024</para>
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// <para>会议链接（飞书用户可通过点击会议链接快捷入会）</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://vc.feishu.cn/j/337736498</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>APPLink用于唤起飞书APP入会。"{?}"为占位符，用于配置入会参数，使用时需替换具体值：0表示关闭，1表示打开。preview为入会前的设置页，mic为麦克风，speaker为扬声器，camera为摄像头</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://applink.feishu.cn/client/videochat/open?source=openplatform&amp;action=join&amp;idtype=reservationid&amp;id={?}&amp;preview={?}&amp;mic={?}&amp;speaker={?}&amp;camera={?}</para>
        /// </summary>
        [JsonPropertyName("app_link")]
        public string? AppLink { get; set; }

        /// <summary>
        /// <para>会议转直播链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://meetings.feishu.cn/s/1gub381l4gglv</para>
        /// </summary>
        [JsonPropertyName("live_link")]
        public string? LiveLink { get; set; }

        /// <summary>
        /// <para>预约到期时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608883322</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }
    }

    /// <summary>
    /// <para>预约参数检查信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reserve_correction_check_info")]
    public PostVcV1ReservesApplyResponseDtoReserveCorrectionCheckInfo? ReserveCorrectionCheckInfo { get; set; }

    /// <summary>
    /// <para>预约参数检查信息</para>
    /// </summary>
    public record PostVcV1ReservesApplyResponseDtoReserveCorrectionCheckInfo
    {
        /// <summary>
        /// <para>指定主持人无效id列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("invalid_host_id_list")]
        public string[]? InvalidHostIdList { get; set; }
    }
}
