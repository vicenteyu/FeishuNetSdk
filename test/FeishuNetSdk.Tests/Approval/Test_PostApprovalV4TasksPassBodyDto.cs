// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_PostApprovalV4TasksPassBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 同意审批任务（用户级） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 同意审批任务（用户级） 请求体
/// <para>接口ID：7642253323628383198</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/pass</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fpass</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4TasksPassBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"instance_code":"81D31358-93AF-92D6-7425-01A5D67C4E71",
"task_id":"123456789",
"form":"[{\"id\":\"user_name\", \"type\": \"input\", \"value\":\"ou_123avcssa111\"}]",
"comment":"同意"}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4TasksPassBodyDto>(json);
        Assert.IsNotNull(result);
    }
}