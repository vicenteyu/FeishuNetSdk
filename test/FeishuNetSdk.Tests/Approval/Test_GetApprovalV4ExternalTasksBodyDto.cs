namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 获取三方审批任务状态 请求体
/// <para>接口ID：7117964632137170947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_task%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4ExternalTasksBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instance_ids": ["oa_159160304"],
    "approval_codes": ["B7B65FFE-C2GC-452F-9F0F-9AA8352363D6"],
    "user_ids": ["112321"],
    "status": "PENDING"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.GetApprovalV4ExternalTasksBodyDto>(json);
        Assert.IsNotNull(result);
    }
}