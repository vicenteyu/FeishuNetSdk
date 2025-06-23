namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 根据简历附件创建招聘官网投递任务 响应体
/// <para>接口ID：7097131869725179905</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create_by_attachment</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery%2fcreate_by_attachment</para>
/// </summary>
[TestClass]
public class Test_PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "task_id": "f1c2a0f138ec492d99d7ab73594158ad"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1WebsitesByWebsiteIdDeliveriesCreateByAttachmentResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}