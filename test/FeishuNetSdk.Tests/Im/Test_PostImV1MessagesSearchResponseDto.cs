// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostImV1MessagesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 搜索消息 响应体
/// <para>接口ID：7649057980096580572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesSearchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "om_40eb06e7b84dc71c03e00ida3c754892",
                "display_info": "飞书<h>搜索</h>",
                "meta_data": {
                    "message_id": "om_40eb06e7b84dc71c03e00ida3c754892",
                    "type": "post",
                    "create_time": "2026-03-21T16:15:30+08:00",
                    "update_time": "2026-03-21T16:15:30+08:00",
                    "position": 0,
                    "chat_id": "oc_5ad11d72b830411d72b836c20",
                    "from_id": "ou-7890123456abcdef",
                    "thread_id": "omt_d4be107c616a",
                    "thread_position": 10,
                    "is_p2p_chat": false
                }
            }
        ],
        "total": 100,
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "notice": "The query is too long and has been truncated to the first 50 characters for search."
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1MessagesSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}