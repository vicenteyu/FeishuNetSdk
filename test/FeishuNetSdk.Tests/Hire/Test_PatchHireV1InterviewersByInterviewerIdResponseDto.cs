namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新面试官信息 响应体
/// <para>接口ID：7372229724359852033</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/interview-settings/interviewer/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterviewer%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1InterviewersByInterviewerIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "interviewer": {
            "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
            "verify_status": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PatchHireV1InterviewersByInterviewerIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}