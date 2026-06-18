// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_PostApprovalV4InstancesRemindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 单据催办 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 单据催办 请求体
/// <para>接口ID：7642253323628415966</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/remind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fremind</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesRemindBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
    "task_ids": [
        "123456789"
    ],
    "comment": "同意"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4InstancesRemindBodyDto>(json);
        Assert.IsNotNull(result);
    }
}