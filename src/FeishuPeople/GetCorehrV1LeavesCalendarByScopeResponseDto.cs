// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-12
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="GetCorehrV1LeavesCalendarByScopeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>根据适用条件获取工作日历 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 根据适用条件获取工作日历 ID 响应体
/// <para>根据日历的适用范围，获取工作日历 ID。适用范围包含工作地点，工时制度等。</para>
/// <para>接口ID：7412526256520724508</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/calendar_by_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fcalendar_by_scope</para>
/// </summary>
public record GetCorehrV1LeavesCalendarByScopeResponseDto
{
    /// <summary>
    /// <para>工作日历id</para>
    /// <para>必填：否</para>
    /// <para>示例值："6722331851580982798"</para>
    /// </summary>
    [JsonPropertyName("calendar_wk_id")]
    public string? CalendarWkId { get; set; }
}
