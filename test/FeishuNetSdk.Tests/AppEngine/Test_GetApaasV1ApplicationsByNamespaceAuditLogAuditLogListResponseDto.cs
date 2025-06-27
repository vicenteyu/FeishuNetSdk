// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApaasV1ApplicationsByNamespaceAuditLogAuditLogListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询审计日志列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询审计日志列表 响应体
/// <para>接口ID：7418119603744391171</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-audit_log/audit_log_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-audit_log%2faudit_log_list</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1ApplicationsByNamespaceAuditLogAuditLogListResponseDto : TestBase
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
                    "name": "郭xx",
                    "tenant_id": "79888",
                    "email": "gxxx@bytedance.com"
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
                "op_detail": {
                    "2052": "管理员和开发者自动获取所有使用权限"
                },
                "op_source": "20001",
                "status": "18001",
                "failed_reason_i18n": {
                    "2052": "中文失败原因内容"
                },
                "data_changes": [
                    "{\"old\": \"OldData\",\"new\": \"NewData\"}"
                ],
                "app_name": {
                    "2052": "应用示例"
                },
                "keyword_field_app_version": "v1.2.3",
                "keyword_field_functional_sub_module": "223"
            }
        ],
        "total": "10"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1ApplicationsByNamespaceAuditLogAuditLogListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}