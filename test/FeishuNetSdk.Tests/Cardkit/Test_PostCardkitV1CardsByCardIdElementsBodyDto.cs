// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCardkitV1CardsByCardIdElementsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增组件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 新增组件 请求体
/// <para>接口ID：7397253002364551171</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsByCardIdElementsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "type": "insert_after",
    "target_element_id": "markdown_1",
    "uuid": "a0d69e20-1dd1-458b-k525-dfeca4015204",
    "sequence": 1,
    "elements": "[{\"tag\":\"button\",\"element_id\":\"button_1\",\"text\":{\"tag\":\"plain_text\",\"content\":\"查看更多\"},\"type\":\"default\",\"width\":\"default\",\"size\":\"medium\",\"behaviors\":[{\"type\":\"open_url\",\"default_url\":\"https://open.feishu.cn/?lang=zh-CN\",\"pc_url\":\"\",\"ios_url\":\"\",\"android_url\":\"\"}]}]"
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PostCardkitV1CardsByCardIdElementsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}