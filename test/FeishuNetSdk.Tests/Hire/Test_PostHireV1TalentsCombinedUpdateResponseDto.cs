namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新人才 响应体
/// <para>接口ID：7034053347989487644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/combined_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fcombined_update</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsCombinedUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "talent_id": "7021471300428613932",
        "operator_id": "ou_84aad35d084aa403a838cf73ee18467",
        "operator_account_type": 1
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentsCombinedUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}