namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 获取OpenAPI审计日志数据 请求体
/// <para>接口ID：7283168587871223810</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/openapi_log/list_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fopenapi_log%2flist_data</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1OpenapiLogsListDataBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "api_keys": [
        "POST/open-apis/authen/v1/access_token"
    ],
    "start_time": 1610613336,
    "end_time": 1610613336,
    "app_id": "cli_xxx",
    "page_size": 20,
    "page_token": "xxx"
}
""";
        var result = Deserialize<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1OpenapiLogsListDataBodyDto>(json);
        Assert.IsNotNull(result);
    }
}