namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 查询面试官信息列表 响应体
/// <para>接口ID：7372229724359835649</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/recruitment-related-configuration/interview-settings/interviewer/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterviewer%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1InterviewersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "verify_status": 1
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1InterviewersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}