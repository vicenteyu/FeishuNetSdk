namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 批量获取审批实例ID 请求体
/// <para>接口ID：6907569745299046402</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/batch-obtain-approval-instance-ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQDOyUjL0gjM14CN4ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceListBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code":"7C468A54-8745-2245-9675-08B7C63E7A85",
    "start_time":1567690398020,
    "end_time":1567690398020,
    "offset":0,
    "limit":100
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceListBodyDto>(json);
        Assert.IsNotNull(result);
    }
}