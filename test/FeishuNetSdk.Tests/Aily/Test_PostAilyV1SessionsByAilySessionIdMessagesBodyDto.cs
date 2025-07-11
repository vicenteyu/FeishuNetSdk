// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAilyV1SessionsByAilySessionIdMessagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送智能伙伴消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 发送 Aily 消息 请求体
/// <para>接口ID：7358047310868283396</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-aily_message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-aily_message%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1SessionsByAilySessionIdMessagesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "idempotent_id": "idempotent_id_1",
    "content_type": "MDX",
    "content": "你好",
    "file_ids": [
        "file_4d9nu1ev3a2rq"
    ],
    "quote_message_id": "message_4de9bpg70qskh",
    "mentions": [
        {
            "entity_id": "ou_5ad573a6411d72b8305fda3a9c15c70e",
            "identity_provider": "FEISHU",
            "key": "@_user_1",
            "name": "张三",
            "aily_id": "1794840334557292"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1SessionsByAilySessionIdMessagesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}