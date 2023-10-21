using Newtonsoft.Json;
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 获取妙记统计数据 响应体
/// <para>通过这个接口，可以获得妙记的访问情况统计，包含PV、UV、访问过的 user id、访问过的 user timestamp。</para>
/// <para>接口ID：7181729161035612161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/minutes-v1/minute-statistics/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute-statistics%2fget</para>
/// </summary>
public record GetMinutesV1MinutesByMinuteTokenStatisticsResponseDto
{
    /// <summary>
    /// <para>妙记浏览信息统计</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("statistics")]
    public Statictics? Statistics { get; set; }

    /// <summary>
    /// <para>妙记浏览信息统计</para>
    /// </summary>
    public record Statictics
    {
        /// <summary>
        /// <para>用户浏览数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("user_view_count")]
        public string? UserViewCount { get; set; }

        /// <summary>
        /// <para>页面浏览数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// <para>最大长度：20</para>
        /// </summary>
        [JsonProperty("page_view_count")]
        public string? PageViewCount { get; set; }

        /// <summary>
        /// <para>用户浏览列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100000</para>
        /// </summary>
        [JsonProperty("user_view_list")]
        public UserViewDetail[]? UserViewLists { get; set; }

        /// <summary>
        /// <para>用户浏览列表</para>
        /// </summary>
        public record UserViewDetail
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_612b787ccd3259fb3c816b3f678dxxxx</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>用户的最近查看时间timestamp（ms级别）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1669121332000</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("view_time")]
            public string? ViewTime { get; set; }
        }
    }
}
