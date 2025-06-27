// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAilyV1SessionsByAilySessionIdMessagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发送智能伙伴消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 发送智能伙伴消息 响应体
/// <para>接口ID：7358047310868283396</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-aily_message/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-aily_message%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1SessionsByAilySessionIdMessagesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message": {
            "id": "message_4df45f2xknvcc",
            "session_id": "session_4dfunz7sp1g8m",
            "run_id": "run_4dfrxvctjqzzj",
            "content_type": "MDX",
            "content": "你好",
            "files": [
                {
                    "id": "file_4d9nu1ev3a2rq",
                    "mime_type": "image/png",
                    "file_name": "发票.png",
                    "metadata": "{}",
                    "created_at": "1711975665710",
                    "preview_url": {
                        "url": "http://path_to_file",
                        "expired_at": "1719413169"
                    }
                }
            ],
            "quote_message_id": "message_4de9bpg70qskh",
            "sender": {
                "entity_id": "ou_5ad573a6411d72b8305fda3a9c15c70e",
                "identity_provider": "FEISHU",
                "sender_type": "USER",
                "aily_id": "1794840334557292"
            },
            "mentions": [
                {
                    "entity_id": "ou_5ad573a6411d72b8305fda3a9c15c70e",
                    "identity_provider": "FEISHU",
                    "key": "@_user_1",
                    "name": "张三",
                    "aily_id": "1794840334557292"
                }
            ],
            "plain_text": "你好",
            "created_at": "1711975665710",
            "status": "COMPLETED"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Aily.PostAilyV1SessionsByAilySessionIdMessagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}