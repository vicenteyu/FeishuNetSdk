// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_PostApprovalV4TasksForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转交审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 转交审批任务（用户级） 请求体
/// <para>接口ID：7651444911796473026</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fforward</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4TasksForwardBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
    "task_id": "123456789",
    "transfer_user_id": "ou_abacc112aa",
    "comment": "转交给产品专员处理"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4TasksForwardBodyDto>(json);
        Assert.IsNotNull(result);
    }
}