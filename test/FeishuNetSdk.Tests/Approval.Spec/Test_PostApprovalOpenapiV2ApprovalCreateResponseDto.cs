namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 创建审批定义 响应体
/// <para>接口ID：6907569743420686338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-store-app-integration/create-an-approval-definition</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUzNyYjL1cjM24SN3IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2ApprovalCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_code":"81D31358-93AF-92D6-7425-01A5D67C4E71"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2ApprovalCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}