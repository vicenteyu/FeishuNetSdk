namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 审批实例抄送 请求体
/// <para>接口ID：6907569743419523074</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/cc-instance</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADOzYjLwgzM24CM4MjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceCcBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code":"7C468A54-8745-2245-9675-08B7C63E7A85",
    "instance_code":"7C468A54-8745-2245-9675-08B7C63E7A85",
    "user_id":"f7cb567e",
    "open_id":"ou_123456",
    "cc_user_ids": ["f7cb567e"],
    "cc_open_ids": ["ou_123456"],
    "comment": "123"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceCcBodyDto>(json);
        Assert.IsNotNull(result);
    }
}