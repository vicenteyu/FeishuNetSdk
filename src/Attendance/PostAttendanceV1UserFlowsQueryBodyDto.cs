// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserFlowsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询打卡流水 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 批量查询打卡流水 请求体
/// <para>通过用户 ID 获取用户的打卡流水记录。返回信息主要包含：</para>
/// <para>* 用户id和创建者id</para>
/// <para>* 记录信息</para>
/// <para>* 打卡位置信息、时间信息</para>
/// <para>* 打卡方式信息</para>
/// <para>* GPS 打卡：location_name（定位地址信息）</para>
/// <para>* Wi-Fi 打卡：ssid（wifi名称）、bssid（mac地址）</para>
/// <para>* 考勤机打卡：device_id（考勤机设备id）</para>
/// <para>对应页面功能打卡管理-[打卡记录](https://example.feishu.cn/people/workforce-management/manage/statistics/flow)</para>
/// <para>接口ID：7044467124773617665</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fquery</para>
/// </summary>
public record PostAttendanceV1UserFlowsQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表，长度不超过 50</para>
    /// <para>必填：是</para>
    /// <para>示例值：[ "abd754f7"]</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];

    /// <summary>
    /// <para>查询的起始时间，秒级时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1566641088</para>
    /// </summary>
    [JsonPropertyName("check_time_from")]
    public string CheckTimeFrom { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询的结束时间，秒级时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1566641088</para>
    /// </summary>
    [JsonPropertyName("check_time_to")]
    public string CheckTimeTo { get; set; } = string.Empty;
}
