// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesByMinuteTokenClipBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建妙记片段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 创建妙记片段 请求体
/// <para>接口ID：7676147106222902224</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/clip</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fclip</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesByMinuteTokenClipBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "time_ranges": [
        {
            "start_time": "1000",
            "end_time": "20000"
        }
    ],
    "title": "快速上手飞书妙记-片段"
}
""";
        var result = Deserialize<FeishuNetSdk.Minutes.PostMinutesV1MinutesByMinuteTokenClipBodyDto>(json);
        Assert.IsNotNull(result);
    }
}