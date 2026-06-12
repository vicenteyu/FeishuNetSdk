// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostImV2ChatsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索群组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 搜索群组 响应体
/// <para>接口ID：7649732836954606572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/chat/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostImV2ChatsSearchResponseDto : TestBase
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
                "id": "7890123456abcdef",
                "display_info": "飞书<h>搜索</h>",
                "meta_data": {
                    "chat_id": "7890123456abcdef",
                    "create_time": "2026-03-21T16:15:30+08:00",
                    "update_time": "2026-03-21T16:15:30+08:00",
                    "external": true,
                    "chat_mode": "group",
                    "description": "群描述",
                    "avatar": "https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg",
                    "name": "研发讨论群",
                    "owner_id": "4d7a3c6g",
                    "owner_id_type": "user_id",
                    "tenant_key": "7010970696222244883",
                    "chat_status": "normal"
                }
            }
        ],
        "total": 10,
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "notice": "The query is too long and has been truncated to the first 50 characters for search."
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV2ChatsSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}