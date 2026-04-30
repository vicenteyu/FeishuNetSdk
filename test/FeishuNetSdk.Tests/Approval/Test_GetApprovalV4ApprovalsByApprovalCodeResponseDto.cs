// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="Test_GetApprovalV4ApprovalsByApprovalCodeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查看指定审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 查看指定审批定义 响应体
/// <para>接口ID：7114621541589860355</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fget</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4ApprovalsByApprovalCodeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_name": "Payment",
        "status": "ACTIVE",
        "form": "[{\"id\": \"widget1\", \"custom_id\": \"user_name\",\"name\": \"Item application\",\"type\": \"textarea\",\"printable\": true,\"required\": true}]",
        "node_list": [
            {
                "name": "Approval",
                "need_approver": true,
                "node_id": "46e6d96cfa756980907209209ec03b64",
                "custom_node_id": "46e6d96cfa756980907209209ec03b64",
                "node_type": "AND",
                "approver_chosen_multi": true,
                "approver_chosen_range": [
                    {
                        "approver_range_type": 2,
                        "approver_range_ids": [
                            "0"
                        ]
                    }
                ],
                "require_signature": false
            }
        ],
        "viewers": [
            {
                "type": "TENANT",
                "id": "ou_e03053f0541cecc3269d7a9dc34a0b21",
                "user_id": "f7cb567e"
            }
        ],
        "approval_admin_ids": [
            "ou_3cda9c969f737aaa05e6915dce306cb9"
        ],
        "form_widget_relation": "{\"groups\":[{\"id\":\"1\",\"parent_widgets_ids\":[\"widget1\",\"widget4\"],\"children_widget_ids\":[\"widget2.widget3\"],\"conditions\":[{\"parents_expr\":{\"type\":\"Multi\",\"expr\":{\"type\":\"and\",\"exprs\":[{\"type\":\"SingleWidget\",\"expr\":{\"type\":\"in\",\"widget_id\":\"widget1\",\"expect\":{\"type\":\"local\",\"value\":[{\"value\":\"value_0\"},{\"value\":\"value_1\"}]}}},{\"type\":\"Const\",\"expr\":{\"value\":true,\"widget_ids\":[\"widget4\"]}}]}},\"children_rule\":{\"expr\":{\"type\":\"SingleWidget\",\"expr\":{\"type\":\"in\",\"widget_id\":\"widget2.widget3\",\"expect\":{\"type\":\"local\",\"value\":[{\"value\":\"value_3\"},{\"value\":\"value_5\"}]}}},\"actions\":[{\"type\":\"SetOptions\",\"widget_id\":\"widget2.widget3\",\"value\":{\"type\":\"local\",\"value\":[{\"value\":\"value_3\"},{\"value\":\"value_4\"}]}}]}}]}]}"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}