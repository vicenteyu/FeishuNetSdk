namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 批量获取用户迁移状态 响应体
/// <para>接口ID：7202615512559058947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1UserMigrationsSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "user_id": "ou_1234567890abcdef1234567890abcdef",
                "dest_geo": "us",
                "task_id": "task_1234567890abcdef",
                "status": "1",
                "progress": 20
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1UserMigrationsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}