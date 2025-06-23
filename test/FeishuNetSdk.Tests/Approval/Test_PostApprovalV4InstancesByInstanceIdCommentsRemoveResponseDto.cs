namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 清空评论 响应体
/// <para>接口ID：7117964632137252867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fremove</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesByInstanceIdCommentsRemoveResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "instance_id": "6A123516-FB88-470D-A428-9AF58B71B3C0",
        "external_id": "6A123516-FB88-470D-A428-9AF58B71B3C0"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4InstancesByInstanceIdCommentsRemoveResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}