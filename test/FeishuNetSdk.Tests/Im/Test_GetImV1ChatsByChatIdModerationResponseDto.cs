// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetImV1ChatsByChatIdModerationResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取群成员发言权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取群成员发言权限 响应体
/// <para>接口ID：6951292665602883586</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-moderation%2fget</para>
/// </summary>
[TestClass]
public class Test_GetImV1ChatsByChatIdModerationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "moderation_setting": "moderator_list",
        "page_token": "dmJCRHhpd3JRbGV1VEVNRFFyTitRWDY5ZFkybmYrMEUwMUFYT0VMMWdENEtuYUhsNUxGMDIwemtvdE5ORjBNQQ==",
        "has_more": true,
        "items": [
            {
                "user_id_type": "user_id",
                "user_id": "4d7a3c6g",
                "tenant_key": "2ca1d211f64f6438"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1ChatsByChatIdModerationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}