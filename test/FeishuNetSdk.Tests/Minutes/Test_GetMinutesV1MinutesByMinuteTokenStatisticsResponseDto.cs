// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMinutesV1MinutesByMinuteTokenStatisticsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙记统计数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 获取妙记统计数据 响应体
/// <para>接口ID：7181729161035612161</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/minutes-v1/minute-statistics/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute-statistics%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMinutesV1MinutesByMinuteTokenStatisticsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "statistics": {
            "user_view_count": "3",
            "page_view_count": "20",
            "user_view_list": [
                {
                    "user_id": "ou_612b787ccd3259fb3c816b3f678dxxxx",
                    "view_time": "1669121332000"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.GetMinutesV1MinutesByMinuteTokenStatisticsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}