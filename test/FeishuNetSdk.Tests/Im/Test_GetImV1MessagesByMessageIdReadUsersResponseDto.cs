// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetImV1MessagesByMessageIdReadUsersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询消息已读信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 查询消息已读信息 响应体
/// <para>接口ID：6946222929790386204</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/read_users</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fread_users</para>
/// </summary>
[TestClass]
public class Test_GetImV1MessagesByMessageIdReadUsersResponseDto : TestBase
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
                "user_id_type": "open_id",
                "user_id": "ou_9b851f7b51a9d58d109982337c46f3de",
                "timestamp": "1609484183000",
                "tenant_key": "736588c9260f175e"
            }
        ],
        "has_more": true,
        "page_token": "GxmvlNRvP0NdQZpa7yIqf_Lv_QuBwTQ8tXkX7w-irAghVD_TvuYd1aoJ1LQph86O-XImC4X9j9FhUPhXQDvtrQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1MessagesByMessageIdReadUsersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}