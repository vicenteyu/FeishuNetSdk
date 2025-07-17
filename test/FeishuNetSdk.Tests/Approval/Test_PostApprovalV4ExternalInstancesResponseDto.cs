// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4ExternalInstancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 同步三方审批实例 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 同步三方审批实例 响应体
/// <para>接口ID：7114621541589811203</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_instance%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ExternalInstancesResponseDto : TestBase
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
            "approval_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
            "status": "PENDING",
            "extra": "{\"xxx\":\"xxx\",\"business_key\":\"xxx\"}",
            "instance_id": "24492654",
            "links": {
                "pc_link": "https://applink.feishu.cn/client/mini_program/open?mode=appCenter&appId=cli_9c90fc38e07a9101&path=pc/pages/detail?id=1234",
                "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&path=pages/detail?id=1234"
            },
            "title": "@i18n@1",
            "form": [
                {
                    "name": "@i18n@2",
                    "value": "@i18n@3"
                }
            ],
            "user_id": "a987sf9s",
            "user_name": "@i18n@9",
            "open_id": "ou_be73cbc0ee35eb6ca54e9e7cc14998c1",
            "department_id": "od-8ec33278bc2",
            "department_name": "@i18n@10",
            "start_time": "1556468012678",
            "end_time": "1556468012678",
            "update_time": "1556468012678",
            "display_method": "BROWSER",
            "update_mode": "UPDATE",
            "task_list": [
                {
                    "task_id": "112534",
                    "user_id": "a987sf9s",
                    "open_id": "ou_be73cbc0ee35eb6ca54e9e7cc14998c1",
                    "title": "i18n1",
                    "links": {
                        "pc_link": "https://applink.feishu.cn/client/mini_program/open?mode=appCenter&appId=cli_9c90fc38e07a9101&path=pc/pages/detail?id=1234",
                        "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&path=pages/detail?id=1234"
                    },
                    "status": "PENDING",
                    "extra": "{\"xxx\":\"xxx\",\"complete_reason\":\"approved\"}",
                    "create_time": "1556468012678",
                    "end_time": "1556468012678",
                    "update_time": "1556468012678",
                    "action_context": "123456",
                    "action_configs": [
                        {
                            "action_type": "APPROVE",
                            "action_name": "@i18n@5",
                            "is_need_reason": false,
                            "is_reason_required": false,
                            "is_need_attachment": false
                        }
                    ],
                    "display_method": "BROWSER",
                    "exclude_statistics": false,
                    "node_id": "node",
                    "node_name": "i18n@name",
                    "generate_type": "EXTERNAL_CONSIGN"
                }
            ],
            "cc_list": [
                {
                    "cc_id": "123456",
                    "user_id": "12345",
                    "open_id": "ou_be73cbc0ee35eb6ca54e9e7cc14998c1",
                    "links": {
                        "pc_link": "https://applink.feishu.cn/client/mini_program/open?mode=appCenter&appId=cli_9c90fc38e07a9101&path=pc/pages/detail?id=1234",
                        "mobile_link": "https://applink.feishu.cn/client/mini_program/open?appId=cli_9c90fc38e07a9101&path=pages/detail?id=1234"
                    },
                    "read_status": "READ",
                    "extra": "{\"xxx\":\"xxx\"}",
                    "title": "xxx",
                    "create_time": "1556468012678",
                    "update_time": "1556468012678",
                    "display_method": "BROWSER"
                }
            ],
            "i18n_resources": [
                {
                    "locale": "zh-CN",
                    "texts": [
                        {
                            "key": "@i18n@1",
                            "value": "people"
                        }
                    ],
                    "is_default": true
                }
            ],
            "trusteeship_url_token": "788981c886b1c28ac29d1e68efd60683d6d90dfce80938ee9453e2a5f3e9e306",
            "trusteeship_user_id_type": "user_id",
            "trusteeship_urls": {
                "form_detail_url": "https://#{your_domain}/api/form_detail",
                "action_definition_url": "https://#{your_domain}/api/action_definition",
                "approval_node_url": "https://#{your_domain}/api/approval_node",
                "action_callback_url": "https://#{your_domain}/api/action_callback",
                "pull_business_data_url": "https://#{your_domain}/api/pull_business_data"
            },
            "trusteeship_cache_config": {
                "form_policy": "DISABLE",
                "form_vary_with_locale": false,
                "form_version": "1"
            },
            "resource_region": "cn"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4ExternalInstancesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}