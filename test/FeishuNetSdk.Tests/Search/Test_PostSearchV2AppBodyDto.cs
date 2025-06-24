// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSearchV2AppBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Search;

/// <summary>
/// 测试 搜索应用 请求体
/// <para>接口ID：7208771563588075523</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/suite-search/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fapp%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2AppBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "测试应用"
}
""";
        var result = Deserialize<FeishuNetSdk.Search.PostSearchV2AppBodyDto>(json);
        Assert.IsNotNull(result);
    }
}