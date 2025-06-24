// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV1IdGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询审批 ID（专用） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 查询审批 ID（专用） 请求体
/// <para>接口ID：6907568031544737794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search-approval-id-(dedicated)</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDN5UjLxQTO14SM0kTN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV1IdGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tenant_key":"2ec1bb30a64f1666",
    "user_id_list":["18gee666"],
    "lark_id_list":[6636933555614666666,6636933555614666667]
}
""";
        var result = Deserialize<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV1IdGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}