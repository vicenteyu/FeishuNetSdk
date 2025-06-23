namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建试卷列表 请求体
/// <para>接口ID：7195815976042561538</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam_paper/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam_paper%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoExamPapersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "account_id": "7147998241542539527",
    "paper_list": [
        {
            "id": "7147998241542539527",
            "name": "春季测评",
            "duration": 30,
            "question_count": 30,
            "start_time": "1658676234053",
            "end_time": "1672444800000"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoExamPapersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}