// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutHireV1WebsitesByWebsiteIdChannelsByChannelIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新招聘官网推广渠道 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新招聘官网推广渠道 响应体
/// <para>接口ID：7097130725263491073</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1WebsitesByWebsiteIdChannelsByChannelIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "id": "7085989097067563300",
        "name": "微信推广渠道",
        "link": "http://recrui-demo.jobs.xxx.cn/485083/?spread=A1KM6A5",
        "code": "A1KM6A5"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PutHireV1WebsitesByWebsiteIdChannelsByChannelIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}