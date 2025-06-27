// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV2InstanceGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取单个审批实例详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 获取单个审批实例详情 请求体
/// <para>接口ID：6907569524100497409</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/obtain-single-approval-instance-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDNyUjLxQjM14SM0ITN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV2InstanceGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
    "locale": "zh-CN",
    "open_id": "xxxxx",
    "user_id": "xxxxxxx"
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV2InstanceGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}