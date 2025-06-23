namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 实例列表查询 请求体
/// <para>接口ID：6907568073251946498</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/instance-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjMxYjL0ITM24CNyEjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "lwiu098wj",
    "approval_code": "EB828003-9FFE-4B3F-AA50-2E199E2ED942",
    "instance_code": "EB828003-9FFE-4B3F-AA50-2E199E2ED943",
    "instance_external_id": "xxxxx",
    "group_external_id": "xxxx",
    "instance_title": "xxx",
    "instance_status": "PENDING",
    "instance_start_time_from": 1547654251506,
    "instance_start_time_to": 1547654251506,
    "locale": "zh-CN",
    "offset": 0,
    "limit": 50
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}