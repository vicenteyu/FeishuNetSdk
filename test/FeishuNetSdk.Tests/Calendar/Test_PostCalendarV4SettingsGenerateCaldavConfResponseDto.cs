// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCalendarV4SettingsGenerateCaldavConfResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 生成 CalDAV 配置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Calendar;

/// <summary>
/// 测试 生成 CalDAV 配置 响应体
/// <para>接口ID：6952888507002929179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/setting/generate_caldav_conf</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fsetting%2fgenerate_caldav_conf</para>
/// </summary>
[TestClass]
public class Test_PostCalendarV4SettingsGenerateCaldavConfResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "password": "A67h23sd8",
        "user_name": "ZhangSan",
        "server_address": "caldav.domain.com",
        "device_name": "iPhone"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Calendar.PostCalendarV4SettingsGenerateCaldavConfResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}