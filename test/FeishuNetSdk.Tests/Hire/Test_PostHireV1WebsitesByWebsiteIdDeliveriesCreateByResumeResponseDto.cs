namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 新建招聘官网投递 响应体
/// <para>接口ID：6990661791098716163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_resume</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_resume</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "delivery": {
            "application_id": "6960663240925956657",
            "id": "6960663240925956655",
            "job_id": "6960663240925956659",
            "job_post_id": "6960663240925956658",
            "portal_resume_id": "6960663240925956660",
            "user_id": "6960663240925956656",
            "talent_id": "7095600054216542508"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdDeliveriesCreateByResumeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}