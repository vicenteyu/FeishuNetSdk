namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 查询任务列表 请求体
/// <para>接口ID：7117964632137138179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4TasksSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "lwiu098wj",
    "approval_code": "EB828003-9FFE-4B3F-AA50-2E199E2ED942",
    "instance_code": "EB828003-9FFE-4B3F-AA50-2E199E2ED943",
    "instance_external_id": "EB828003-9FFE-4B3F-AA50-2E199E2ED976",
    "group_external_id": "1234567",
    "task_title": "test",
    "task_status": "PENDING",
    "task_start_time_from": "1547654251506",
    "task_start_time_to": "1547654251506",
    "locale": "zh-CN",
    "task_status_list": [
        "PENDING"
    ],
    "order": 2
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4TasksSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}