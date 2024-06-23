// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCalendarV4ExchangeBindingsByExchangeBindingIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询 Exchange 账户的绑定状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 查询 Exchange 账户的绑定状态 响应体
/// <para>调用该接口获取 Exchange 账户的绑定状态，包括 Exchange 日历的同步状态。</para>
/// <para>接口ID：6963176044560744450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/exchange_binding/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fexchange_binding%2fget</para>
/// </summary>
public record GetCalendarV4ExchangeBindingsByExchangeBindingIdResponseDto
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

    /// <summary>
    /// <para>Exchange 账户的同步状态。</para>
    /// <para>必填：否</para>
    /// <para>示例值：doing</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doing：日历正在同步</item>
    /// <item>cal_done：日历同步完成</item>
    /// <item>timespan_done：近期时间段同步完成</item>
    /// <item>done：日程同步完成</item>
    /// <item>err：同步错误</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>Exchange 绑定的唯一标识 ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ZW1haWxfYWRtaW5fZXhhbXBsZUBvdXRsb29rLmNvbSBlbWFpbF9hY2NvdW50X2V4YW1wbGVAb3V0bG9vay5jb20=</para>
    /// </summary>
    [JsonPropertyName("exchange_binding_id")]
    public string? ExchangeBindingId { get; set; }
}
