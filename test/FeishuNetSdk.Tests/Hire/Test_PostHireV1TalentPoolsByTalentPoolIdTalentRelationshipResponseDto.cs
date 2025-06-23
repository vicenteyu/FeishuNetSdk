namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 将人才加入人才库 响应体
/// <para>接口ID：7218853190452445188</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent_pool/move_talent</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fmove_talent</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "talent_pool_id": "6930815272790114325",
        "talent_id": "6930815272790114324"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}