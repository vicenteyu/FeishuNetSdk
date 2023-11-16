namespace FeishuNetSdk.Calendar.Spec;
/// <summary>
/// 生成 CalDAV 配置 响应体
/// <para>用于为当前用户生成一个CalDAV账号密码，用于将飞书日历信息同步到本地设备日历。</para>
/// <para>接口ID：6952888507002929179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/setting/generate_caldav_conf</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fsetting%2fgenerate_caldav_conf</para>
/// </summary>
public record PostCalendarV4SettingsGenerateCaldavConfResponseDto
{
    /// <summary>
    /// <para>caldav密码</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>
    /// <para>caldav用户名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// <para>服务器地址</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("server_address")]
    public string? ServerAddress { get; set; }

    /// <summary>
    /// <para>设备名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("device_name")]
    public string? DeviceName { get; set; }
}
