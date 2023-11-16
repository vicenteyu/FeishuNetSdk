namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用红点 请求体
/// <para>更新应用红点信息，用于工作台场景</para>
/// <para>接口ID：7291103260878356482</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app_badge/set</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapp_badge%2fset</para>
/// </summary>
public record PostApplicationV6AppBadgeSetBodyDto
{
    /// <summary>
    /// <para>用户ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_d317f090b7258ad0372aa53963cda70d</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>badge数据版本号</para>
    /// <para>必填：是</para>
    /// <para>示例值：1664360599355</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    /// <summary>
    /// <para>badge extra 信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public string? Extra { get; set; }

    /// <summary>
    /// <para>pc端badge数量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pc")]
    public ClientBadgeNum? Pc { get; set; }

    /// <summary>
    /// <para>pc端badge数量</para>
    /// </summary>
    public record ClientBadgeNum
    {
        /// <summary>
        /// <para>h5能力的badge数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("web_app")]
        public int? WebApp { get; set; }

        /// <summary>
        /// <para>小程序能力的badge数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("gadget")]
        public int? Gadget { get; set; }
    }

    /// <summary>
    /// <para>移动端badge数量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public ClientBadgeNum? Mobile { get; set; }
}
