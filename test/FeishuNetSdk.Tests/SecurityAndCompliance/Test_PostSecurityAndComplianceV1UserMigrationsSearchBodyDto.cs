namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 批量获取用户迁移状态 请求体
/// <para>接口ID：7202615512559058947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1UserMigrationsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_ids": [
        "ou_1234567890abcdef1234567890abcdef"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1UserMigrationsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}