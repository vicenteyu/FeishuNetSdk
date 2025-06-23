namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 添加笔试结果 请求体
/// <para>接口ID：7033979950131118084</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexam%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1ExamsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "application_id": "6891565253964859661",
    "exam_resource_name": "笔试试卷",
    "score": 100.0,
    "uuid": "6949805467799537964",
    "operator_id": "ou_f476cb099ac9227c9bae09ce46112579"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1ExamsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}