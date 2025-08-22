// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_GetHireV1OfferApprovalTemplatesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 Offer 审批流列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取 Offer 审批流列表 响应体
/// <para>接口ID：7002055120885235715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_approval_template/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_approval_template%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1OfferApprovalTemplatesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "1234452132",
        "items": [
            {
                "id": "1213213123123",
                "name": {
                    "zh_cn": "Offer 审批流1",
                    "en_us": "Offer approval flow config 1"
                },
                "create_time": "1628512038000",
                "remark": "test",
                "department_list": [
                    {
                        "id": "1213213123123",
                        "name": "部门名A",
                        "en_name": "DepartmentA"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1OfferApprovalTemplatesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}