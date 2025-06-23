namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 批量获取人才ID 响应体
/// <para>接口ID：7125370772851458076</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/batch_get_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fbatch_get_id</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsBatchGetIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "talent_list": [
            {
                "talent_id": "6891560630172518670",
                "mobile_code": "86",
                "mobile_number": "182900291190",
                "email": "foo@bytedance.com",
                "identification_type": 1,
                "identification_number": "510403xxxxxxxx",
                "is_onboarded": true
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentsBatchGetIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}