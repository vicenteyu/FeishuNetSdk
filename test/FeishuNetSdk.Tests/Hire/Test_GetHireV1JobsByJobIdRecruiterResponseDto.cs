namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取职位上的招聘人员信息 响应体
/// <para>接口ID：7254447878126878748</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/job/recruiter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2frecruiter</para>
/// </summary>
[TestClass]
public class Test_GetHireV1JobsByJobIdRecruiterResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "info": {
            "id": "1618209327096",
            "recruiter_id": "ou_efk39117c300506837def50545420c6a",
            "hiring_manager_id_list": [
                "on_94a1ee5551019f18cd73d9f111898cf2"
            ],
            "assistant_id_list": [
                "on_94a1ee5551019f18cd73d9f111898cf2"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1JobsByJobIdRecruiterResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}