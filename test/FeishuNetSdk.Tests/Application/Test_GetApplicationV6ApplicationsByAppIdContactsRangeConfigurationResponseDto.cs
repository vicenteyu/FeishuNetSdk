// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApplicationV6ApplicationsByAppIdContactsRangeConfigurationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取应用通讯录权限范围配置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用通讯录权限范围配置 响应体
/// <para>接口ID：7218093640928133124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/contacts_range_configuration</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fcontacts_range_configuration</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ApplicationsByAppIdContactsRangeConfigurationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "contacts_range": {
            "contacts_scope_type": "some",
            "visible_list": {
                "open_ids": [
                    "ou_4065981088f8ef67a504ba8bd6b24d85"
                ],
                "department_ids": [
                    "od-4b4a6907ad726ea07b27b0d2882b7c65"
                ],
                "group_ids": [
                    "b6d1g5dd6fd26186"
                ]
            }
        },
        "has_more": true,
        "page_token": "new-e3c5a0627cdf0c2e057da7257b90376a"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ApplicationsByAppIdContactsRangeConfigurationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}