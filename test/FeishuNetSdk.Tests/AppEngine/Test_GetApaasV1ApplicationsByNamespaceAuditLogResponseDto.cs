namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询审计日志详情 响应体
/// <para>接口ID：7418119603744407555</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-audit_log/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-audit_log%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1ApplicationsByNamespaceAuditLogResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data": {
            "log_id": "7376574450886557740",
            "basic_info": {
                "log_type": "10000",
                "audit_scope": "15001",
                "env_type": "16003",
                "app_id": "app123",
                "module": "17001",
                "op_type": "19001",
                "app_name": {
                    "2052": "应用名称"
                }
            },
            "op_info": {
                "operator": {
                    "id": "1768491480010814",
                    "name": "郭x",
                    "tenant_id": "72222",
                    "email": "gxxxxx.jim@bytedance.com"
                },
                "outsider": true,
                "op_detail": {
                    "language_code": 2052,
                    "text": "内部用户 <a id=1645514825206 type=\"user\">赵四</a> 登录了平台"
                },
                "status": "18001",
                "failed_reason": "登录失败",
                "failed_reason_i18n": {
                    "2052": "失败原因"
                },
                "op_time": "1723634726874",
                "data_object": "object_api_aaa",
                "op_source": "20001",
                "data_changes": [
                    "{\"old\": \"OldData\",  \"new\": \"NewData\" }"
                ]
            },
            "login_info": {
                "login_type": "11001"
            },
            "device_info": {
                "device_id": "device_1234",
                "web_device_id": "webDevice_1234",
                "terminal_type": "2",
                "os_type": "14002",
                "os_version": "14.6"
            },
            "net_info": {
                "client_ip": "192.168.1.1",
                "ip_loc": "中国北京",
                "ip_provider": "ISP_com",
                "referer": "https://example.com/referer",
                "origin": "https://example.com/origin",
                "user_agent": "Mozilla/5.0 (iPhone; CPU iPhone OS 14_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1ApplicationsByNamespaceAuditLogResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}