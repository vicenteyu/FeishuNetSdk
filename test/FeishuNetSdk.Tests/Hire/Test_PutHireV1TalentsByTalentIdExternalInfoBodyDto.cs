namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新人才外部信息 请求体
/// <para>接口ID：7045100014603550721</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent-external_info%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutHireV1TalentsByTalentIdExternalInfoBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "external_create_time": "1639992265035"
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PutHireV1TalentsByTalentIdExternalInfoBodyDto>(json);
        Assert.IsNotNull(result);
    }
}