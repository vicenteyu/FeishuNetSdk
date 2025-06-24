// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建多维表格 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 创建多维表格 请求体
/// <para>接口ID：7047733935745007620</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name":"一篇新的多维表格",
    "folder_token": "fldcnqquW1svRIYVT2Np6Iabcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}