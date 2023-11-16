namespace FeishuNetSdk.Minutes;
/// <summary>
/// 获取妙记信息 响应体
/// <para>通过这个接口，可以得到一篇妙记的基础概述信息，包含 `owner_id`、`create_time`、标题、封面、时长和 URL。</para>
/// <para>接口ID：7181729161035628545</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/minutes-v1/minute/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fget</para>
/// </summary>
public record GetMinutesV1MinutesByMinuteTokenResponseDto
{
    /// <summary>
    /// <para>妙记基本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("minute")]
    public GetMinutesV1MinutesByMinuteTokenResponseDtoMinute? Minute { get; set; }

    /// <summary>
    /// <para>妙记基本信息</para>
    /// </summary>
    public record GetMinutesV1MinutesByMinuteTokenResponseDtoMinute
    {
        /// <summary>
        /// <para>妙记token</para>
        /// <para>必填：否</para>
        /// <para>示例值：obcnq3b9jl72l83w4f14xxxx</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>所有者ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_612b787ccd3259fb3c816b3f678dxxxx</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>妙记创建时间timestamp（ms级别）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1669098360477</para>
        /// <para>最大长度：15</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>妙记标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：xxx的视频会议</para>
        /// <para>最大长度：100000</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>妙记封面链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://internal-api-drive-stream.feishu-pre.cn/space/api/box/stream/download/all/boxcncsI4EIhCSA1RLDsXDpxxxx</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("cover")]
        public string? Cover { get; set; }

        /// <summary>
        /// <para>妙记时长（ms级别）</para>
        /// <para>必填：否</para>
        /// <para>示例值：314000</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// <para>妙记链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://bytedance.feishu-pre.cn/minutes/obcnq3b9jl72l83w4f14xxxx</para>
        /// <para>最大长度：1000</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
