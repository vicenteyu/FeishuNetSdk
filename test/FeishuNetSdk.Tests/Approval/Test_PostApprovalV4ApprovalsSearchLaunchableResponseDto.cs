// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="Test_PostApprovalV4ApprovalsSearchLaunchableResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索可发起的审批定义 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 搜索可发起的审批定义 响应体
/// <para>接口ID：7678280659161042125</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/search_launchable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fsearch_launchable</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ApprovalsSearchLaunchableResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approvals": [
            {
                "approval_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
                "approval_name": "请假",
                "description": "请假审批",
                "is_external": false,
                "create_link": "https://www.example.com"
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.PostApprovalV4ApprovalsSearchLaunchableResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}