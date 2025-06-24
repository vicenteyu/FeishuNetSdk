// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchImV1MessagesByMessageIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用发送的消息卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新应用发送的消息卡片 请求体
/// <para>接口ID：6946222931479543809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchImV1MessagesByMessageIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": "{\"elements\":[{\"tag\":\"div\",\"text\":{\"content\":\"This is the plain text\",\"tag\":\"plain_text\"}}],\"header\":{\"template\":\"blue\",\"title\":{\"content\":\"This is the title\",\"tag\":\"plain_text\"}}}"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PatchImV1MessagesByMessageIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}