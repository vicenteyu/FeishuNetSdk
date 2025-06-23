namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建招聘官网用户 响应体
/// <para>接口ID：6990661791098634243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-site_user%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdSiteUsersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "site_user": {
            "user_id": "6960663240925956620",
            "name": "dan27",
            "email": "dan27@163.com",
            "external_id": "6960663240925956621",
            "mobile": "182900291190",
            "mobile_country_code": "CN_1"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdSiteUsersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}