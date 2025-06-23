namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 回传笔试安排结果 请求体
/// <para>接口ID：7195815979079401473</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_exam/login_info</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_exam%2flogin_info</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoExamsByExamIdLoginInfoBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "result": 0,
    "msg": "success",
    "exam_login_info": {
        "exam_url": "https://xxxx/xxxx/xxxx",
        "username": "waxsdfbhg",
        "password": "xxxxxx"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoExamsByExamIdLoginInfoBodyDto>(json);
        Assert.IsNotNull(result);
    }
}