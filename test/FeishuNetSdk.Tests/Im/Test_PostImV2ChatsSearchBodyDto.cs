// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostImV2ChatsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索群组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 搜索群组 请求体
/// <para>接口ID：7649732836954606572</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/chat/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fchat%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostImV2ChatsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "部门群",
    "filter": {
        "search_types": [
            "private"
        ],
        "member_ids": [
            "ou-7890123456abcdef"
        ],
        "is_manager": true,
        "disable_search_by_user": true,
        "chat_modes": [
            "thread"
        ]
    },
    "sorter": "create_time_desc"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV2ChatsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}