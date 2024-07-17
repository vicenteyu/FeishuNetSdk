// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="GetAttendanceV1UserFlowsByUserFlowIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询打卡流水 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询打卡流水 响应体
/// <para>通过打卡记录 ID 获取用户的打卡流水记录。返回信息主要包含：</para>
/// <para>* 用户id和创建者id</para>
/// <para>* 记录信息</para>
/// <para>* 打卡位置信息、时间信息</para>
/// <para>* 打卡方式信息</para>
/// <para>* GPS 打卡：location_name（定位地址信息）</para>
/// <para>* Wi-Fi 打卡：ssid（wifi名称）、bssid（mac地址）</para>
/// <para>* 考勤机打卡：device_id（考勤机设备id）</para>
/// <para>* 打卡结果</para>
/// <para>对应页面功能打卡管理-[打卡记录](https://example.feishu.cn/people/workforce-management/manage/statistics/flow)</para>
/// <para>接口ID：7044467124773535745</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fget</para>
/// </summary>
public record GetAttendanceV1UserFlowsByUserFlowIdResponseDto
{
    /// <summary>
    /// <para>用户 ID，对应employee_type</para>
    /// <para>必填：是</para>
    /// <para>示例值：abd754f7</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>记录创建者 ID，对应employee_type</para>
    /// <para>必填：是</para>
    /// <para>示例值：abd754f7</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string CreatorId { get; set; } = string.Empty;

    /// <summary>
    /// <para>打卡位置名称信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：西溪八方城</para>
    /// </summary>
    [JsonPropertyName("location_name")]
    public string LocationName { get; set; } = string.Empty;

    /// <summary>
    /// <para>打卡时间，精确到秒的时间戳</para>
    /// <para>必填：是</para>
    /// <para>示例值：1611476284</para>
    /// </summary>
    [JsonPropertyName("check_time")]
    public string CheckTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>打卡备注</para>
    /// <para>必填：是</para>
    /// <para>示例值：上班打卡</para>
    /// </summary>
    [JsonPropertyName("comment")]
    public string Comment { get; set; } = string.Empty;

    /// <summary>
    /// <para>对应打卡流水记录ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6709359313699356941</para>
    /// </summary>
    [JsonPropertyName("record_id")]
    public string? RecordId { get; set; }

    /// <summary>
    /// <para>打卡 Wi-Fi 的 SSID</para>
    /// <para>必填：否</para>
    /// <para>示例值：b0:b8:67:5c:1d:72</para>
    /// </summary>
    [JsonPropertyName("ssid")]
    public string? Ssid { get; set; }

    /// <summary>
    /// <para>打卡 Wi-Fi 的 MAC 地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：b0:b8:67:5c:1d:72</para>
    /// </summary>
    [JsonPropertyName("bssid")]
    public string? Bssid { get; set; }

    /// <summary>
    /// <para>是否为外勤打卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_field")]
    public bool? IsField { get; set; }

    /// <summary>
    /// <para>是否为 Wi-Fi 打卡</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_wifi")]
    public bool? IsWifi { get; set; }

    /// <summary>
    /// <para>记录生成方式，在开放平台调用时，此参数无效，内部值始终是7</para>
    /// <para>必填：否</para>
    /// <para>示例值：7</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：用户打卡</item>
    /// <item>1：管理员修改</item>
    /// <item>2：用户补卡</item>
    /// <item>3：系统自动生成</item>
    /// <item>4：下班免打卡</item>
    /// <item>5：考勤机</item>
    /// <item>6：极速打卡</item>
    /// <item>7：考勤开放平台导入</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// <para>打卡照片列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("photo_urls")]
    public string[]? PhotoUrls { get; set; }

    /// <summary>
    /// <para>打卡设备ID（只支持小程序打卡，导入时无效）</para>
    /// <para>必填：否</para>
    /// <para>示例值：99e0609ee053448596502691a81428654d7ded64c7bd85acd982d26b3636c37d</para>
    /// </summary>
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; set; }

    /// <summary>
    /// <para>打卡结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：Invalid</para>
    /// <para>可选值：<list type="bullet">
    /// <item>NoNeedCheck：无需打卡</item>
    /// <item>SystemCheck：系统打卡</item>
    /// <item>Normal：正常</item>
    /// <item>Early：早退</item>
    /// <item>Late：迟到</item>
    /// <item>SeriousLate：严重迟到</item>
    /// <item>Lack：缺卡</item>
    /// <item>Invalid：无效</item>
    /// <item>None：无状态</item>
    /// <item>Todo：尚未打卡</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("check_result")]
    public string? CheckResult { get; set; }

    /// <summary>
    /// <para>用户导入的外部打卡记录ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：record_123</para>
    /// </summary>
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// <para>唯一幂等键</para>
    /// <para>必填：否</para>
    /// <para>示例值：****_***</para>
    /// </summary>
    [JsonPropertyName("idempotent_id")]
    public string? IdempotentId { get; set; }
}
