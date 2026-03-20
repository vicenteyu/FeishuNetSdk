namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 迁移用户 请求体
/// <para>接口ID：7202615512559026179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1UserMigrationsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "7064408494200487938"
    ],
    "dest_geo": "sg"
}
""";
        var result = Deserialize<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1UserMigrationsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}