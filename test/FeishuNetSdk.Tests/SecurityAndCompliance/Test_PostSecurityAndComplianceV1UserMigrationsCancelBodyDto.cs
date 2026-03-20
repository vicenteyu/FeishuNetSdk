namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 取消用户迁移 请求体
/// <para>接口ID：7202615512558977027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fcancel</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1UserMigrationsCancelBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "7064408494200487xxx"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1UserMigrationsCancelBodyDto>(json);
        Assert.IsNotNull(result);
    }
}