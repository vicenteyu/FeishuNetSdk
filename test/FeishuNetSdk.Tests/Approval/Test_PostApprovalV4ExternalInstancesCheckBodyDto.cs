// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalV4ExternalInstancesCheckBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 校验三方审批实例 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 校验三方审批实例 请求体
/// <para>接口ID：7114621541589909507</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_instance/check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_instance%2fcheck</para>
/// </summary>
[TestClass]
public class Test_PostApprovalV4ExternalInstancesCheckBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instances": [
        {
            "instance_id": "1234234234242423",
            "update_time": "1591603040000",
            "tasks": [
                {
                    "task_id": "112253",
                    "update_time": "1591603040000"
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.PostApprovalV4ExternalInstancesCheckBodyDto>(json);
        Assert.IsNotNull(result);
    }
}