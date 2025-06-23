namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 转发消息 响应体
/// <para>接口ID：7210967154035621891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fforward</para>
/// </summary>
[TestClass]
public class Test_PostImV1MessagesByMessageIdForwardResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "message_id": "om_dc13264520392913993dd051dba21dcf",
        "root_id": "om_40eb06e7b84dc71c03e009ad3c754195",
        "parent_id": "om_d4be107c616aed9c1da8ed8068570a9f",
        "msg_type": "text",
        "create_time": "1615380573411",
        "update_time": "1615380573411",
        "deleted": false,
        "updated": false,
        "chat_id": "oc_5ad11d72b830411d72b836c20",
        "sender": {
            "id": "cli_9f427eec54ae901b",
            "id_type": "app_id",
            "sender_type": "app",
            "tenant_key": "736588c9260f175e"
        },
        "body": {
            "content": "{\"text\":\"test content\"}"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1MessagesByMessageIdForwardResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}