// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCardkitV1CardsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建卡片实体 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 创建卡片实体 请求体
/// <para>接口ID：7397265677100974083</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "type": "card_json",
  "data": "{\"schema\":\"2.0\",\"header\":{\"title\":{\"content\":\"项目进度更新提醒\",\"tag\":\"plain_text\"}},\"config\":{\"streaming_mode\":true,\"summary\":{\"content\":\"\"},\"streaming_config\":{\"print_frequency_ms\":{\"default\":70,\"android\":70,\"ios\":70,\"pc\":70},\"print_step\":{\"default\":1,\"android\":1,\"ios\":1,\"pc\":1},\"print_strategy\":\"fast\"}},\"body\":{\"elements\":[{\"tag\":\"markdown\",\"content\":\"截至今日，项目完成度已达80%\",\"element_id\":\"markdown_1\"}]}}"
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PostCardkitV1CardsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}