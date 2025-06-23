namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 将人才加入人才库 请求体
/// <para>接口ID：7218853190452445188</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent_pool/move_talent</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent_pool%2fmove_talent</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "6930815272790114324",
    "add_type": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentPoolsByTalentPoolIdTalentRelationshipBodyDto>(json);
        Assert.IsNotNull(result);
    }
}