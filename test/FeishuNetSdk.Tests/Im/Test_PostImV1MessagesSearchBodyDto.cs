// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostImV1MessagesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 搜索消息 请求体
/// <para>接口ID：7649057980096580572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "下午去哪团建",
    "filter": {
        "from_ids": [
            "ou-7890123456abcdef"
        ],
        "chat_ids": [
            "ou-7890123456abcdef"
        ],
        "time_range": {
            "start_time": "2026-03-21T16:15:30+08:00",
            "end_time": "2026-03-21T16:15:30+08:00"
        },
        "include_attachment_types": [
            "image"
        ],
        "from_types": [
            "user"
        ],
        "at_chatter_ids": [
            "ou-7890123456abcdef"
        ],
        "chat_type": "group",
        "is_at_me": true,
        "exclude_from_types": [
            "user"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}