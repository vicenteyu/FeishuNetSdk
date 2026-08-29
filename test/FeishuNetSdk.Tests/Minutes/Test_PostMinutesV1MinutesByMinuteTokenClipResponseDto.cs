// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="Test_PostMinutesV1MinutesByMinuteTokenClipResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建妙记片段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 创建妙记片段 响应体
/// <para>接口ID：7676147106222902224</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/clip</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fclip</para>
/// </summary>
[TestClass]
public class Test_PostMinutesV1MinutesByMinuteTokenClipResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "minute_url": "https://sample.feishu.cn/minutes/obcnq3b9jl72l83w4f14xxxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.PostMinutesV1MinutesByMinuteTokenClipResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}