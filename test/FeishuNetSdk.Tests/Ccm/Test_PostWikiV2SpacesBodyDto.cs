// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostWikiV2SpacesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建知识空间 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建知识空间 请求体
/// <para>接口ID：7023947709203922948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostWikiV2SpacesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "知识空间",
    "description": "知识空间描述"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostWikiV2SpacesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}