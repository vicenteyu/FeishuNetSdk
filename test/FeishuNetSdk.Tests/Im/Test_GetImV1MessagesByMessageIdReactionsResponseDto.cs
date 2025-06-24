// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetImV1MessagesByMessageIdReactionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取消息表情回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 获取消息表情回复 响应体
/// <para>接口ID：6990603997012279298</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-reaction/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2flist</para>
/// </summary>
[TestClass]
public class Test_GetImV1MessagesByMessageIdReactionsResponseDto : TestBase
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
                "reaction_id": "ZCaCIjUBVVWSrm5L-3ZTw****",
                "operator": {
                    "operator_id": "ou_ff0b7ba35fb****",
                    "operator_type": "user"
                },
                "action_time": "1626086391570",
                "reaction_type": {
                    "emoji_type": "SMILE"
                }
            }
        ],
        "has_more": true,
        "page_token": "YhljsPiGfUgnVAg9urvRFd-BvSqRL****"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.GetImV1MessagesByMessageIdReactionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}