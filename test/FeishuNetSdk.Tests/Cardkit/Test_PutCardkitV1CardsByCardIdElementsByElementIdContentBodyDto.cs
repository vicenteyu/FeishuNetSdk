// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 流式更新文本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 流式更新文本 请求体
/// <para>接口ID：7397253002364649475</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/content</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fcontent</para>
/// </summary>
[TestClass]
public class Test_PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "uuid": "a0d69e20-1dd1-458b-k525-dfeca4015204",
    "content": "这是更新后的文本内容。将以打字机式的效果输出",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto>(json);
        Assert.IsNotNull(result);
    }
}