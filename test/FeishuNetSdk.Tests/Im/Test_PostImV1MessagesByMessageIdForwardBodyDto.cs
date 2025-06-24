// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1MessagesByMessageIdForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 转发消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 转发消息 请求体
/// <para>接口ID：7210967154035621891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fforward</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesByMessageIdForwardBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "receive_id": "ou_a0553eda9014c201e6969b478895c230"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1MessagesByMessageIdForwardBodyDto>(json);
        Assert.IsNotNull(result);
    }
}