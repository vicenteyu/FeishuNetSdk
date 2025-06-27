// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取审批实例ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 批量获取审批实例ID 响应体
/// <para>接口ID：6907569745299046402</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/batch-obtain-approval-instance-ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQDOyUjL0gjM14CN4ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data": {
        "instance_code_list": [
            "357C21A0-2069-4F6B-955F-1DFBE6710C51",
            "A6F07B2A-0503-4197-8FD7-FEB40C79B47B",
            "3D9ED45B-0806-4B55-8356-BC0FF517408C",
            "33BF276D-0217-436D-A565-3081E5000E63",
            "F7765ABC-2609-49D3-B040-1BCBFD15E3B8"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}