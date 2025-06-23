namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建审批实例 请求体
/// <para>接口ID：7114621541589827587</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code":"4202AD96-9EC1-4284-9C48-B923CDC4F30B",
    "user_id":"59a92c4a",
    "open_id":"ou_806a18fb5bdf525e38ba219733bdbd73",
    "form":"[{\"id\":\"111\",\"type\":\"input\",\"value\":\"11111\"},{\"id\":\"222\",\"required\":true,\"type\":\"dateInterval\",\"value\":{\"start\":\"2019-10-01T08:12:01+08:00\",\"end\":\"2019-10-02T08:12:01+08:00\",\"interval\": 2.0}},{\"id\":\"333\",\"type\":\"radioV2\",\"value\":\"1\"},{\"id\":\"444\",\"type\":\"number\", \"value\":\"4\"},{\"id\":\"555\",\"type\":\"textarea\",\"value\":\"fsafs\"}]",
    "node_approver_user_id_list":[
        {"key": "46e6d96cfa756980907209209ec03b64","value":["59a92c4a"]},
        {"key": "manager_node_id","value":["59a92c4a"]}
    ],
    "node_approver_open_id_list":[
        {"key": "46e6d96cfa756980907209209ec03b64","value":["ou_806a18fb5bdf525e38ba219733bdbd73"]},
        {"key": "manager_node_id","value":["ou_806a18fb5bdf525e38ba219733bdbd73"]}
    ],
    "node_cc_user_id_list":[
        {"key": "46e6d96cfa756980907209209ec03b64","value":["59a92c4a"]},
        {"key": "manager_node_id","value":["59a92c4a"]}
    ],
    "node_cc_open_id_list":[
        {"key": "46e6d96cfa756980907209209ec03b64","value":["ou_806a18fb5bdf525e38ba219733bdbd73"]},
        {"key": "manager_node_id","value":["ou_806a18fb5bdf525e38ba219733bdbd73"]}
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4InstancesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}