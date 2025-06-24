// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV1PinsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 Pin 消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 Pin 消息 响应体
/// <para>接口ID：7138313270488858626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1PinsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "pin": {
            "message_id": "om_dc13264520392913993dd051dba21dcf",
            "chat_id": "oc_a0553eda9014c201e6969b478895c230",
            "operator_id": "ou_7d8a6e6df7621556ce0d21922b676706ccs",
            "operator_id_type": "open_id",
            "create_time": "1615380573211"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1PinsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}