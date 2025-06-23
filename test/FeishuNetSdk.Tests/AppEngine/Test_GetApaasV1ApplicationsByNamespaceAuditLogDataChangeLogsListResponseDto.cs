namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询数据变更日志列表 响应体
/// <para>接口ID：7462214121168650243</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-audit_log/data_change_logs_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-audit_log%2fdata_change_logs_list</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1ApplicationsByNamespaceAuditLogDataChangeLogsListResponseDto : TestBase
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
                "log_id": "7376574450886557740",
                "op_time": "1723634726874",
                "log_type": "10000",
                "operator": {
                    "id": "1768491480010814",
                    "name": "郭晋",
                    "tenant_id": "79844",
                    "email": "guojin.jim@bytedance.com"
                },
                "outsider": true,
                "login_type": "11001",
                "lark_tenant_id": "123",
                "apaas_tenant_id": "23333",
                "user_geo": "America/Chicago",
                "client_ip": "192.168.1.1",
                "ip_loc": "中国北京",
                "ip_provider": "ISP_com",
                "referer": "https://example.com/referer",
                "origin": "https://example.com/origin",
                "api_path": "/api/xxx",
                "full_path": "/api/xxx",
                "user_agent": "Mozilla/5.0 (iPhone; CPU iPhone OS 14_6 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/15E148",
                "device_id": "device_1234",
                "web_device_id": "webDevice_1234",
                "terminal_type": "2",
                "os_type": "14002",
                "os_version": "14.6",
                "module": "17001",
                "data_object": "object_api_aaa",
                "audit_scope": "15001",
                "tenant_id": "23335",
                "namespace": "package_aacc",
                "env_type": "16003",
                "op_type": "19001",
                "op_detail": {},
                "op_source": "20001",
                "status": "18001",
                "failed_reason_i18n": {
                    "zh": "失败信息"
                },
                "data_changes": [
                    "{\"old\": \"OldData\",\"new\": \"NewData\"}"
                ],
                "app_name": {
                    "zh": "新闻资讯平台"
                },
                "keyword_field_app_version": "v1.2.3",
                "keyword_field_functional_sub_module": "223"
            }
        ],
        "total": "10"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1ApplicationsByNamespaceAuditLogDataChangeLogsListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}