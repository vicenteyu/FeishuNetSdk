namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新招聘官网推广渠道 请求体
/// <para>接口ID：7097130725263491073</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1WebsitesByWebsiteIdChannelsByChannelIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "channel_name": "微信推广渠道"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1WebsitesByWebsiteIdChannelsByChannelIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}