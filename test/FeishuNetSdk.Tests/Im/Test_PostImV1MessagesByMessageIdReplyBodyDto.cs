// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1MessagesByMessageIdReplyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 回复消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 回复消息 请求体
/// <para>接口ID：6946222929790500892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/reply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2freply</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesByMessageIdReplyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": "{\"text\":\"test content\"}",
    "msg_type": "text",
    "reply_in_thread": true,
    "uuid": "选填，每次调用前请更换，如a0d69e20-1dd1-458b-k525-dfeca4015204"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesByMessageIdReplyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}