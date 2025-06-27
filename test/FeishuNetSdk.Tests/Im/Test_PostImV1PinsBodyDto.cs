// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1PinsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 Pin 消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 Pin 消息 请求体
/// <para>接口ID：7138313270488858626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1PinsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "message_id": "om_dc13264520392913993dd051dba21dcf"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1PinsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}