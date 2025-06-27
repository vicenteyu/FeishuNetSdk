// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSearchV2MessageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Search;

/// <summary>
/// 测试 搜索消息 请求体
/// <para>接口ID：7208771563588059139</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/suite-search/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fmessage%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSearchV2MessageBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "测试消息",
    "from_ids": [
        "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    ],
    "chat_ids": [
        "oc_a0553eda9014c201e6969b478895c230"
    ],
    "message_type": "image",
    "at_chatter_ids": [
        "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    ],
    "from_type": "user",
    "chat_type": "group_chat",
    "start_time": "1609296809",
    "end_time": "1609296809"
}
""";
        var result = Deserialize<FeishuNetSdk.Search.PostSearchV2MessageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}