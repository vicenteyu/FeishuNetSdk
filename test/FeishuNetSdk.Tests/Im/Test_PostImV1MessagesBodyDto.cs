// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1MessagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 发送消息 请求体
/// <para>接口ID：6946222931479527425</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "receive_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
    "msg_type": "text",
    "content": "{\"text\":\"test content\"}",
    "uuid": "选填，每次调用前请更换，如a0d69e20-1dd1-458b-k525-dfeca4015204"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}