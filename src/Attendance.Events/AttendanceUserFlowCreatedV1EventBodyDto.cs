// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-29
//
// Last Modified By : yxr
// Last Modified On : 2025-10-29
// ************************************************************************
// <copyright file="AttendanceUserFlowCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>打卡流水 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance.Events;

/// <summary>
/// 打卡流水 事件体
/// </summary>
public record AttendanceUserFlowCreatedV1EventBodyDto() : EventBodyDto("attendance.user_flow.created_v1")
{
    /// <summary>
    /// 打卡 Wi-Fi 的 MAC 地址
    /// </summary>
    [JsonPropertyName("bssid")]
    public string? Bssid { get; set; }

    /// <summary>
    /// 打卡时间，精确到秒的时间戳
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 打卡备注
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// 飞书管理后台 > 组织架构 > 成员与部门 > 成员详情中的用户 ID
    /// </summary>
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; set; }

    /// <summary>
    /// 飞书管理后台 > 组织架构 > 成员与部门 > 成员详情中的工号
    /// </summary>
    [JsonPropertyName("employee_no")]
    public string? EmployeeNo { get; set; }

    /// <summary>
    /// 是否为外勤打卡
    /// </summary>
    [JsonPropertyName("is_field")]
    public bool IsField { get; set; }

    /// <summary>
    /// 是否为 Wi-Fi 打卡
    /// </summary>
    [JsonPropertyName("is_wifi")]
    public bool IsWifi { get; set; }

    /// <summary>
    /// 打卡纬度。注意：目前暂不支持返回经纬度
    /// </summary>
    [JsonPropertyName("latitude")]
    public float Latitude { get; set; }

    /// <summary>
    /// 打卡位置名称信息
    /// </summary>
    [JsonPropertyName("location_name")]
    public string? LocationName { get; set; }

    /// <summary>
    /// 打卡经度。注意：目前暂不支持返回经纬度
    /// </summary>
    [JsonPropertyName("longitude")]
    public float Longitude { get; set; }

    /// <summary>
    /// 打卡照片列表
    /// </summary>
    [JsonPropertyName("photo_urls")]
    public object[]? PhotoUrls { get; set; }

    /// <summary>
    /// 打卡记录 ID
    /// </summary>
    [JsonPropertyName("record_id")]
    public string? RecordId { get; set; }

    /// <summary>
    /// 打卡 Wi-Fi 的 SSID
    /// </summary>
    [JsonPropertyName("ssid")]
    public string? Ssid { get; set; }

    /// <summary>
    /// 记录生成方式，可用值：【0（用户自己打卡），1（管理员修改），2（用户补卡），3（系统自动生成），4（下班免打卡），5（考勤机打卡），6（极速打卡），7（考勤开放平台导入）】
    /// </summary>
    [JsonPropertyName("type")]
    public int Type { get; set; }

    /// <summary>
    /// 疑似作弊打卡行为，0：无疑似作弊，1： 疑似使用作弊软件，2：疑似使用他人的设备打卡，3：疑似多人使用同一设备打卡
    /// </summary>
    [JsonPropertyName("risk_result")]
    public int RiskResult { get; set; }
}