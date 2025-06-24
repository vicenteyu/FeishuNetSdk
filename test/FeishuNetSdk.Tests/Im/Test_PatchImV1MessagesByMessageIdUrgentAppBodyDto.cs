// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchImV1MessagesByMessageIdUrgentAppBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送应用内加急 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 发送应用内加急 请求体
/// <para>接口ID：6948245234036621340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_app</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_app</para>
/// </summary>
[TestClass]
public class Test_PatchImV1MessagesByMessageIdUrgentAppBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id_list": [
        "ou_6yf8af6bgb9100449565764t3382b168"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PatchImV1MessagesByMessageIdUrgentAppBodyDto>(json);
        Assert.IsNotNull(result);
    }
}