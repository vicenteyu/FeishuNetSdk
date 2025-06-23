namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 抄送列表查询 请求体
/// <para>接口ID：6907568073252700162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/cc-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUjMxYjL1ITM24SNyEjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2CcSearchBodyDto : TestBase
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
    "cc_title": "xxx",
    "CcCreateTimeFrom": 1547654251506,
    "CcCreateTimeTo": 1547654251506,
    "read_status": "READ",
    "locale": "zh-CN",
    "offset": 0,
    "limit": 50
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2CcSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}