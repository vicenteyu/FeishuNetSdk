namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建招聘官网推广渠道 响应体
/// <para>接口ID：7097130725263474689</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdChannelsResponseDto : TestBase
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
        "name": "官网微信渠道",
        "link": "http://recrui-demo.jobs.xxx.cn/485083/?spread=A1KM6A5",
        "code": "A1KM6A5"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdChannelsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}