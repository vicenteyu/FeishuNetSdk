namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取招聘需求信息 请求体
/// <para>接口ID：7218888199548633092</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/list_by_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2flist_by_id</para>
/// </summary>
[TestClass]
public class Test_PostHireV1JobRequirementsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "id_list": [
        "6952811314255265796"
    ],
    "short_code_list": [
        "R00407"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1JobRequirementsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}