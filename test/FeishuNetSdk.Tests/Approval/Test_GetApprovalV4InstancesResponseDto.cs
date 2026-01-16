// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-15
//
// Last Modified By : yxr
// Last Modified On : 2026-01-15
// ************************************************************************
// <copyright file="Test_GetApprovalV4InstancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取审批实例 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 批量获取审批实例 ID 响应体
/// <para>接口ID：7114621541589876739</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4InstancesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "instance_code_list": [
            "357C21A0-2069-4F6B-955F-1DFBE6710C51"
        ],
        "page_token": "nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4InstancesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}