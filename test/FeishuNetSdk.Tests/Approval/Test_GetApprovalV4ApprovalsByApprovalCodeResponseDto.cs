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
                            "ou_e03053f0541cecc3269d7a9dc34a0b21"
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
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}