namespace FeishuNetSdk.Tests.SecurityAndCompliance;

/// <summary>
/// 测试 获取OpenAPI审计日志数据 响应体
/// <para>接口ID：7283168587871223810</para>
/// <para>文档地址：https://open.feishu.cn/document/security_and_compliance-v1/openapi_log/list_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fopenapi_log%2flist_data</para>
/// </summary>
[TestClass]
public class Test_PostSecurityAndComplianceV1OpenapiLogsListDataResponseDto : TestBase
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
                "id": "10000",
                "api_key": "POST/open-apis/demo/v1/example",
                "event_time": 1610613336,
                "app_id": "cli_xxx",
                "ip": "192.123.12.1",
                "log_detail": {
                    "path": "/open-apis/demo/v1/example",
                    "method": "POST",
                    "query_param": "{}",
                    "payload": "{\"param1\": \"val1\", \"param2\": \"val2\"}",
                    "status_code": 0,
                    "response": "{\"code\": 0, \"msg\": \"ok\"}"
                }
            }
        ],
        "page_token": "xxxx",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.SecurityAndCompliance.PostSecurityAndComplianceV1OpenapiLogsListDataResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}