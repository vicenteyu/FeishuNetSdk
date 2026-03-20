namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 获取单个用户迁移状态 响应体
/// <para>接口ID：7202615512559042563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fuser_migration%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSecurityAndComplianceV1UserMigrationsByUserIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user_migration": {
            "user_id": "ou_1234567890abcdef1234567890abcdef",
            "dest_geo": "us",
            "task_id": "task-id-360043495213",
            "status": "1",
            "progress": 100
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.GetSecurityAndComplianceV1UserMigrationsByUserIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}