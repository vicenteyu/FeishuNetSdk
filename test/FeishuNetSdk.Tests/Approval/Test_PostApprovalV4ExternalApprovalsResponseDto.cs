namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建三方审批定义 响应体
/// <para>接口ID：7114621541589794819</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_approval/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_approval%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ExternalApprovalsResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4ExternalApprovalsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}