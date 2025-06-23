namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 校验三方审批实例 响应体
/// <para>接口ID：7114621541589909507</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_instance/check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_instance%2fcheck</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ExternalInstancesCheckResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "diff_instances": [
            {
                "instance_id": "1234234234242423",
                "update_time": "1591603040000",
                "tasks": [
                    {
                        "task_id": "112253",
                        "update_time": "1591603040000"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4ExternalInstancesCheckResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}