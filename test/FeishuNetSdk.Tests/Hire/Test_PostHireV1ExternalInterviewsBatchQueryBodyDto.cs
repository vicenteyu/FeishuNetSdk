namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询外部面试列表 请求体
/// <para>接口ID：7407298680640913411</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/get-candidates/import-external-system-information/import-external-interview-info/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExternalInterviewsBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_interview_id_list": [
        "6960663240925956660"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExternalInterviewsBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}