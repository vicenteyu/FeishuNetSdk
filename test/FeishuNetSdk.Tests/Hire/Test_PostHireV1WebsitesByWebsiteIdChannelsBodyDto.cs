// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1WebsitesByWebsiteIdChannelsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新建招聘官网推广渠道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建招聘官网推广渠道 请求体
/// <para>接口ID：7097130725263474689</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdChannelsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "channel_name": "微信推广渠道"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdChannelsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}