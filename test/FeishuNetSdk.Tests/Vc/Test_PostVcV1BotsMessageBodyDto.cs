// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="Test_PostVcV1BotsMessageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送会中消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 发送会中消息 请求体
/// <para>接口ID：7672664994766982391</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/message</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fmessage</para>
/// </summary>
[TestClass]
public class Test_PostVcV1BotsMessageBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "meeting_id": "7628568141510692381",
    "msg_type": "text",
    "content": "请大家看一下这个问题",
    "uuid": "7f3b7fd2-1b64-4f5d-9e8b-2f2d8d3b0c11"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1BotsMessageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}