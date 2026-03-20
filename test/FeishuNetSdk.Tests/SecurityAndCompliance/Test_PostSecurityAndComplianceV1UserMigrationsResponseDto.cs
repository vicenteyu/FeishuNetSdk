namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 迁移用户 响应体
/// <para>接口ID：7202615512559026179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1UserMigrationsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_migrations": [
            {
                "user_id": "123165707875",
                "dest_geo": "us",
                "task_id": "task_1234567890abcdef",
                "status": "1",
                "progress": 20
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1UserMigrationsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}