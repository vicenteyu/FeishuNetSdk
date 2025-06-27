// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetImV1ChatsByChatIdMembersIsInChatResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 判断用户或机器人是否在群里 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 判断用户或机器人是否在群里 响应体
/// <para>接口ID：6946222929790418972</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/is_in_chat</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fis_in_chat</para>
/// </summary>
[TestClass]
public class Test_GetImV1ChatsByChatIdMembersIsInChatResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "is_in_chat": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1ChatsByChatIdMembersIsInChatResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}