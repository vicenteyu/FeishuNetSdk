namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新面试官信息 请求体
/// <para>接口ID：7372229724359852033</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/interview-settings/interviewer/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterviewer%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1InterviewersByInterviewerIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "interviewer": {
        "verify_status": 1
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1InterviewersByInterviewerIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}