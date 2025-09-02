// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-03
//
// Last Modified By : yxr
// Last Modified On : 2025-09-03
// ************************************************************************
// <copyright file="PostCalendarV4CalendarsPrimarysBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取主日历信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 批量获取主日历信息 请求体
/// <para>根据user id列表批量查询指定用户的主日历信息。</para>
/// <para>接口ID：7327132452408393732</para>
/// <para>文档地址：https://open.feishu.cn/document/calendar-v4/calendar/primarys</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar%2fprimarys</para>
/// </summary>
public record PostCalendarV4CalendarsPrimarysBodyDto
{
    /// <summary>
    /// <para>用户 ID 列表，多个 ID 的取值格式为 `["ou_c186b6833e2d5faf2bc587e71ddabcef", "ou_7d8a6e6df7621556ce0d21922b676706"]`。</para>
    /// <para>需要传入与查询参数 user_id_type 相匹配的 ID。例如，`user_id_type=open_id` 时，需要传入用户的 open_id。了解用户 ID 参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();
}
