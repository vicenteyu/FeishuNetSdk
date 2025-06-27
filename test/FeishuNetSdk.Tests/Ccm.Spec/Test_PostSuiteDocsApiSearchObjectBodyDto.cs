// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSuiteDocsApiSearchObjectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索云文档 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 搜索云文档 请求体
/// <para>接口ID：6907569523177439233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/search/document-search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM4UjL4ADO14COwgTN</para>
/// </summary>
[TestClass]
public class Test_PostSuiteDocsApiSearchObjectBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "search_key": "项目",
    "count": 10, 
    "offset": 0,
    "owner_ids": ["13eabcef"],
    "chat_ids": [],
    "docs_types": ["doc", "sheet"]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSuiteDocsApiSearchObjectBodyDto>(json);
        Assert.IsNotNull(result);
    }
}