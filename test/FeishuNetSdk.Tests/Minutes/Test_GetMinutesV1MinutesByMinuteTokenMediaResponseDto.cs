// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMinutesV1MinutesByMinuteTokenMediaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 下载妙记音视频文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes;

/// <summary>
/// 测试 下载妙记音视频文件 响应体
/// <para>接口ID：7289369210564345884</para>
/// <para>文档地址：https://open.feishu.cn/document/minutes-v1/minute-media/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute-media%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMinutesV1MinutesByMinuteTokenMediaResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "download_url": "https://internal-api-drive-stream.feishu-boe.cn/space/api/box/stream/download/authcode/?code=xxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Minutes.GetMinutesV1MinutesByMinuteTokenMediaResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}