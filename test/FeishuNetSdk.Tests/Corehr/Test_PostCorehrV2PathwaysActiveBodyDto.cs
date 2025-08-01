// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2PathwaysActiveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 启停用通道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 启停用通道 请求体
/// <para>接口ID：7508634905587040259</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/active</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2factive</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PathwaysActiveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "pathway_id": "6862995757234914823",
    "active": true
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PathwaysActiveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}