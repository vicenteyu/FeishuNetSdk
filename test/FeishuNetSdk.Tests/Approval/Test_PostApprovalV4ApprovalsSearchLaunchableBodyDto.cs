// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="Test_PostApprovalV4ApprovalsSearchLaunchableBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索可发起的审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 搜索可发起的审批定义 请求体
/// <para>接口ID：7678280659161042125</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/search_launchable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fsearch_launchable</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ApprovalsSearchLaunchableBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "keyword": "请假",
    "locale": "zh-CN: 中文 en-US: 英文 ja-JP: 日文",
    "page_size": 20,
    "page_token": "ASDJHA1323_sda1JSASDFD"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4ApprovalsSearchLaunchableBodyDto>(json);
        Assert.IsNotNull(result);
    }
}