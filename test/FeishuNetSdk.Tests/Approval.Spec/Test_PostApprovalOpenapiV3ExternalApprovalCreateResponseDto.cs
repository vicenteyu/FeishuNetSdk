namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 三方审批定义创建 响应体
/// <para>接口ID：6907569744329883649</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDNyYjLyQjM24iM0IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV3ExternalApprovalCreateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_code": "C30381C8-7A5F-4717-A9CF-C233BF0202D4"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV3ExternalApprovalCreateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}