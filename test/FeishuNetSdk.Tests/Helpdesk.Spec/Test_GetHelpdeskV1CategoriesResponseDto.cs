// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHelpdeskV1CategoriesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取全部知识库分类 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk.Spec;

/// <summary>
/// 测试 获取全部知识库分类 响应体
/// <para>接口ID：6955768699895889922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/list-categories</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2flist-categories</para>
/// </summary>
[TestClass]
public class Test_GetHelpdeskV1CategoriesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "categories": [
            {
                "category_id": "6948728206392295444",
                "id": "6948728206392295444",
                "name": "创建团队和邀请成员",
                "parent_id": "0",
                "helpdesk_id": "6939771743531696147",
                "language": "zh_cn",
                "children": [
                    {
                        "id": "4",
                        "name": "Hardware",
                        "parent_id": "6841014521893552132",
                        "children": [
                            {
                                "id": "5",
                                "name": "Computer",
                                "parent_id": "4",
                                "helpdesk_id": "123456",
                                "language": "en_us"
                            }
                        ],
                        "helpdesk_id": "123456",
                        "language": "en_us"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Helpdesk.Spec.GetHelpdeskV1CategoriesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}