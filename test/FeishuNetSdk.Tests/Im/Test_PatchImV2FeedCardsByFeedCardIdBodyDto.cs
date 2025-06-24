// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchImV2FeedCardsByFeedCardIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 即时提醒 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 即时提醒 请求体
/// <para>接口ID：7291232621641039875</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/groups-bots/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchImV2FeedCardsByFeedCardIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "time_sensitive": true,
    "user_ids": [
        "ou_9d2beb613c85a2412862a49a924558c5"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PatchImV2FeedCardsByFeedCardIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}