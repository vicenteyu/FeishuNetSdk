// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-26
// ************************************************************************
// <copyright file="Test_GetApaasV1AppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查看应用基本信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查看应用基本信息 响应体
/// <para>接口ID：7483060846336999428</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/app/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapp%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1AppsResponseDto : TestBase
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
                "name": [
                    {
                        "language_code": "2052",
                        "text": "测试应用"
                    }
                ],
                "namespace": "package_35f605__c",
                "created_at": 1736480945563,
                "creator": 1818624575806604,
                "owner": 1818624575806604,
                "status": "enabled",
                "app_roles_info": {
                    "admins": [
                        1803710089388154
                    ],
                    "developers": [
                        1803710089388154
                    ],
                    "test_users": [
                        1803710089388154
                    ],
                    "data_admins": [
                        1803710089388154
                    ]
                },
                "icon": "https://ae.feishu.cn/img/namespaces/_global/download/namespace_8aed421832fa4586968596f70e6eaebd_p.jpg",
                "description": [
                    {
                        "language_code": "2052",
                        "text": "测试应用描述"
                    }
                ],
                "type": "custom",
                "enable_status": "enabled",
                "release_status": "released",
                "service_status": "available",
                "service_unavailable_reason": "entitlement_expire",
                "feature_set": "paid",
                "charge_mode": "per_user_per_app",
                "isv_tenant": {
                    "id": "798456",
                    "name": "北京飞书科技有限公司"
                }
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1AppsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}