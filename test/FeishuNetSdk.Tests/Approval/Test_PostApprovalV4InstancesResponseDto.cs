namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 创建审批实例 响应体
/// <para>接口ID：7114621541589827587</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4InstancesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}