// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV3ExternalInstanceCheckBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 三方审批实例校验 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 三方审批实例校验 请求体
/// <para>接口ID：6907569745298604034</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-instance-check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNyYjL1QjM24SN0IjN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV3ExternalInstanceCheckBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "update_times": [
        {
            "instance_id": "1234234234242423",
            "update_time": 1591603040000,
            "tasks": [
                {
                    "task_id": "112253",
                    "update_time": 1591603040000
                },
                {
                    "task_id": "112255",
                    "update_time": 1591603040000
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV3ExternalInstanceCheckBodyDto>(json);
        Assert.IsNotNull(result);
    }
}