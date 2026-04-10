// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="Test_PostImMessagesReactionsBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取消息表情回复 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 批量获取消息表情回复 请求体
/// <para>接口ID：7626724000588991682</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostImMessagesReactionsBatchQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "queries": [
        {
            "message_id": "om_8964d1b4*********2b31383276113",
            "page_token": "YhljsPiGfUgnVAg9urvRFd-BvSqRL20"
        }
    ],
    "page_size_per_message": 10,
    "reaction_type": "LAUGH"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImMessagesReactionsBatchQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}