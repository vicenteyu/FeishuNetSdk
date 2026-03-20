namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 获取地理位置列表 响应体
/// <para>接口ID：7202615512559009795</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/user_migration/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fmulti_geo_entity-tenant%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSecurityAndComplianceV1MultiGeoEntityTenantResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tenant": {
            "available_geo_locations": [
                "sg"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.GetSecurityAndComplianceV1MultiGeoEntityTenantResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}