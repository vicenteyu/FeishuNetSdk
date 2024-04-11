namespace FeishuNetSdk.Calendar;
/// <summary>
/// 将 Exchange 账户绑定到飞书账户 请求体
/// <para>调用该接口将 Exchange 账户绑定到飞书账户，进而支持 Exchange 日历的导入。</para>
/// <para>接口ID：6963176044560728066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/exchange_binding/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fexchange_binding%2fcreate</para>
/// </summary>
public record PostCalendarV4ExchangeBindingsBodyDto
{
    /// <summary>
    /// <para>Exchange 的 admin 账户。</para>
    /// <para>必填：否</para>
    /// <para>示例值：email_admin_example@outlook.com</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("admin_account")]
    public string? AdminAccount { get; set; }

    /// <summary>
    /// <para>需绑定的 Exchange 账户。</para>
    /// <para>必填：否</para>
    /// <para>示例值：email_account_example@outlook.com</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("exchange_account")]
    public string? ExchangeAccount { get; set; }

    /// <summary>
    /// <para>用户 ID，即 Exchange 账户绑定的飞书账户 ID。关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_xxxxxxxxxxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
