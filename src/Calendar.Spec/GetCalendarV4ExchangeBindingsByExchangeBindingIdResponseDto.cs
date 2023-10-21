using Newtonsoft.Json;
namespace FeishuNetSdk.Calendar.Spec;
/// <summary>
/// 查询 Exchange 账户的绑定状态 响应体
/// <para>本接口获取Exchange账户的绑定状态，包括exchange日历是否同步完成。</para>
/// <para>接口ID：6963176044560744450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/exchange_binding/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fexchange_binding%2fget</para>
/// </summary>
public record GetCalendarV4ExchangeBindingsByExchangeBindingIdResponseDto
{
    /// <summary>
    /// <para>admin账户</para>
    /// <para>**字段权限要求**：</para>
    /// <para><md-perm name="contact:user.email:readonly" desc="获取用户邮箱信息" support_app_types="custom" tags="">获取用户邮箱信息</md-perm></para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("admin_account")]
    public string? AdminAccount { get; set; }

    /// <summary>
    /// <para>用户绑定的exchange账户</para>
    /// <para>**字段权限要求**：</para>
    /// <para><md-perm name="contact:user.email:readonly" desc="获取用户邮箱信息" support_app_types="custom" tags="">获取用户邮箱信息</md-perm></para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("exchange_account")]
    public string? ExchangeAccount { get; set; }

    /// <summary>
    /// <para>exchange账户绑定user唯一标识id，参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>exchange账户同步状态</para>
    /// <para>**可选值有**：</para>
    /// <para>doing:日历正在同步,cal_done:日历同步完成,timespan_done:近期时间段同步完成,done:日程同步完成,err:同步错误</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doing：日历正在同步</item>
    /// <item>cal_done：日历同步完成</item>
    /// <item>timespan_done：近期时间段同步完成</item>
    /// <item>done：日程同步完成</item>
    /// <item>err：同步错误</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>exchange绑定唯一标识id。参见[exchange绑定ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/exchange_binding/introduction#12533d5e)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("exchange_binding_id")]
    public string? ExchangeBindingId { get; set; }
}
