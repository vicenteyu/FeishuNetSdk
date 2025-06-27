// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteImV1ChatsByChatIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 将用户或机器人移出群聊 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 将用户或机器人移出群聊 响应体
/// <para>接口ID：6946222929790468124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteImV1ChatsByChatIdMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "invalid_id_list": [
            "4d7a3c6g"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.DeleteImV1ChatsByChatIdMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}