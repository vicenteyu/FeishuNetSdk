// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4InstancesCcBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 抄送审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 抄送审批实例 请求体
/// <para>接口ID：7114621541589745667</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fcc</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4InstancesCcBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "instance_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
    "user_id": "f7cb567e",
    "cc_user_ids": [
        "f7cb567e"
    ],
    "comment": "ok"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4InstancesCcBodyDto>(json);
        Assert.IsNotNull(result);
    }
}