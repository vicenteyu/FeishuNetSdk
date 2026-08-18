// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="Test_PostVcV1BotsMessageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送会中消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 发送会中消息 响应体
/// <para>接口ID：7672664994766982391</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/message</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fmessage</para>
/// </summary>
[TestClass]
public class Test_PostVcV1BotsMessageResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "uuid": "a1b2c3d4-5678-90ef-ghij-klmnopqrstuv"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.PostVcV1BotsMessageResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}