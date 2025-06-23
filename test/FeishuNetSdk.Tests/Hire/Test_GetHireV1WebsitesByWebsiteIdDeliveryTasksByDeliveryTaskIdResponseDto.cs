namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘官网投递任务结果 响应体
/// <para>接口ID：7097130726429179906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-delivery_task%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1WebsitesByWebsiteIdDeliveryTasksByDeliveryTaskIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "status": 1,
        "delivery": {
            "application_id": "6960663240925956657",
            "id": "6960663240925956655",
            "job_id": "6960663240925956659",
            "job_post_id": "6960663240925956658",
            "portal_resume_id": "6960663240925956660",
            "user_id": "6960663240925956656",
            "talent_id": "7095600054216542508"
        },
        "status_msg": " ",
        "extra_info": "  "
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1WebsitesByWebsiteIdDeliveryTasksByDeliveryTaskIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}