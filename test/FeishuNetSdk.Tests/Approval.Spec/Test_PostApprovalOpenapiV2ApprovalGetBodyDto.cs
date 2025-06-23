namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 查看审批定义 请求体
/// <para>接口ID：6907569744330358785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/obtain-single-approval-form</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADNyUjLwQjM14CM0ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2ApprovalGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "locale": "en-US"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2ApprovalGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}