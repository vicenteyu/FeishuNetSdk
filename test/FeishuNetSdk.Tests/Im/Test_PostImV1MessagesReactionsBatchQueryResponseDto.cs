// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="Test_PostImV1MessagesReactionsBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取消息表情回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 批量获取消息表情回复 响应体
/// <para>接口ID：7626724000588991682</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesReactionsBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "success_msg_reaction_details": [
            {
                "message_id": "om_a8f2294b************a1a38afaac9d",
                "has_more": true,
                "page_token": "NzYxNDA2NjMyNzA3Mzg1Mjk0NDoy",
                "message_reaction_items": [
                    {
                        "reaction_id": "ZCaCIjUBVVWSrm5L-3ZTw****",
                        "operator": {
                            "operator_id": "ou_ff0b7ba35fb********67dfc8b885136",
                            "operator_type": "user"
                        },
                        "action_time": "1626086391570",
                        "emoji_type": "SMILE"
                    }
                ]
            }
        ],
        "success_msg_reaction_counts": [
            {
                "message_id": "om_8964d1b4*********2b31383276113",
                "reaction_count": [
                    {
                        "reaction_type": "LAUGH",
                        "count": "20"
                    }
                ]
            }
        ],
        "fail_msg_reaction_details": [
            {
                "message_id": "om_8964d1b4*********2b31383276113",
                "fail_reason": "invalid"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1MessagesReactionsBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}