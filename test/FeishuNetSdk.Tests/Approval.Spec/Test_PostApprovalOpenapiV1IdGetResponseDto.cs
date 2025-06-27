// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApprovalOpenapiV1IdGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询审批 ID（专用） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 查询审批 ID（专用） 响应体
/// <para>接口ID：6907568031544737794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search-approval-id-(dedicated)</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDN5UjLxQTO14SM0kTN</para>
/// </summary>
[TestClass]
public class Test_PostApprovalOpenapiV1IdGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
     "data":{
       "user_id_map": {
            "18gee666": "6636933555614666666",
            "18gee666": "6636933555614666666",
            "18gee666": "6636933555614666666"
        },
        "lark_id_map": {
            "6636933555614121998": "18gee666",
            "6747579129199067139": "18gee666"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.PostApprovalOpenapiV1IdGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}