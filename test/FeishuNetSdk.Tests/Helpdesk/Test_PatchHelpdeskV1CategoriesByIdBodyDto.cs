// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchHelpdeskV1CategoriesByIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新知识库分类详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 更新知识库分类详情 请求体
/// <para>接口ID：6955768699895595010</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHelpdeskV1CategoriesByIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "创建团队和邀请成员",
    "parent_id": "0"
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PatchHelpdeskV1CategoriesByIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}