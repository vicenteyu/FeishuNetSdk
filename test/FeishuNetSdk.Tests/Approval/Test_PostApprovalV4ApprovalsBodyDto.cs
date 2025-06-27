// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4ApprovalsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建审批定义 请求体
/// <para>接口ID：7114621541589712899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ApprovalsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_name": "@i18n@approval_name",
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "description": "@i18n@description",
    "viewers": [
        {
            "viewer_type": "USER",
            "viewer_user_id": "19a294c2",
            "viewer_department_id": "od-ac9d697abfa990b715dcc33d58a62a9d"
        }
    ],
    "form": {
        "form_content": "[{\"id\":\"user_name\", \"type\": \"input\", \"required\":true, \"name\":\"@i18n@widget1\"}]"
    },
    "node_list": [
        {
            "id": "START",
            "name": "@i18n@node_name",
            "node_type": "AND",
            "approver": [
                {
                    "type": "Supervisor",
                    "user_id": "f7cb567e",
                    "level": "3"
                }
            ],
            "ccer": [
                {
                    "type": "Supervisor",
                    "user_id": "f7cb567e",
                    "level": "3"
                }
            ],
            "privilege_field": {
                "writable": [
                    "user_name"
                ],
                "readable": [
                    "user_name"
                ]
            },
            "approver_chosen_multi": false,
            "approver_chosen_range": [
                {
                    "type": "ALL",
                    "id_list": [
                        "f7cb567e"
                    ]
                }
            ],
            "starter_assignee": "STARTER"
        }
    ],
    "settings": {
        "revert_interval": 0,
        "revert_option": 0,
        "reject_option": 0,
        "quick_approval_option": 1
    },
    "config": {
        "can_update_viewer": false,
        "can_update_form": false,
        "can_update_process": false,
        "can_update_revert": false,
        "help_url": "https://xxx.xxx.xxx"
    },
    "icon": 0,
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
    "process_manager_ids": [
        "1c5ea995"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4ApprovalsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}