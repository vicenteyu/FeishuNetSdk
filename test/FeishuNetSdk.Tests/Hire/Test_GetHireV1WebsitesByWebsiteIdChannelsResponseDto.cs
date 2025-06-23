namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘官网推广渠道列表 响应体
/// <para>接口ID：7097130725263441921</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1WebsitesByWebsiteIdChannelsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1NTUyMjM2NzIsImlkIjpudWxsfQ",
        "website_channel_list": [
            {
                "id": "7085989097067563300",
                "name": "微信推广渠道",
                "link": "http://recrui-demo.jobs.xxx.cn/485083/?spread=A1KM6A5",
                "code": "A1KM6A5"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1WebsitesByWebsiteIdChannelsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}