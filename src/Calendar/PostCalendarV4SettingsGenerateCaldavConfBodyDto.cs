// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCalendarV4SettingsGenerateCaldavConfBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>生成 CalDAV 配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Calendar;
/// <summary>
/// 生成 CalDAV 配置 请求体
/// <para>调用该接口为当前用户生成一个 CalDAV 账号密码，用于将飞书日历信息同步到本地设备日历。</para>
/// <para>接口ID：6952888507002929179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/setting/generate_caldav_conf</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fsetting%2fgenerate_caldav_conf</para>
/// </summary>
public record PostCalendarV4SettingsGenerateCaldavConfBodyDto
{
    /// <summary>
    /// <para>需要同步日历的设备名，在日历中用来展示。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：iPhone</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("device_name")]
    public string? DeviceName { get; set; }
}
