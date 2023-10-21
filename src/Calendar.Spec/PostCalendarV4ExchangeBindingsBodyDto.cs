using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar.Spec;
/// <summary>
/// 将 Exchange 账户绑定到飞书账户 请求体
/// <para>本接口将Exchange账户绑定到飞书账户，进而支持Exchange日历的导入{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=calendar&version=v4&resource=exchange_binding&method=create)</para>
/// <para>接口ID：6963176044560728066</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/exchange_binding/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fexchange_binding%2fcreate</para>
/// </summary>
public record PostCalendarV4ExchangeBindingsBodyDto
{
    /// <summary>
    /// <para>admin账户</para>
    /// <para>**示例值**："email_admin_example@outlook.com"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `500` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("admin_account")]
    public string? AdminAccount { get; set; }

    /// <summary>
    /// <para>用户绑定的exchange账户</para>
    /// <para>**示例值**："email_account_example@outlook.com"</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `500` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("exchange_account")]
    public string? ExchangeAccount { get; set; }

    /// <summary>
    /// <para>exchange账户绑定user唯一标识id，参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>**示例值**："ou_xxxxxxxxxxxxxxxxxx"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }
}
