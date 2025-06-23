namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 操作人才标签 请求体
/// <para>接口ID：7404770953199730690</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/tag</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2ftag</para>
/// </summary>
[TestClass]
public class Test_PostHireV1TalentsByTalentIdTagBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "operation": 1,
    "tag_id_list": [
        "6960663240925956661"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1TalentsByTalentIdTagBodyDto>(json);
        Assert.IsNotNull(result);
    }
}