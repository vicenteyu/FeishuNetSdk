// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostLingoV1EntitiesMatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 精准搜索词条 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 精准搜索词条 请求体
/// <para>接口ID：7249689905697079324</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/entity/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fmatch</para>
/// </summary>
[TestClass]
public class Test_PostLingoV1EntitiesMatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "word": "飞书词典"
}
""";
        var result = Deserialize<FeishuNetSdk.Baike.PostLingoV1EntitiesMatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}