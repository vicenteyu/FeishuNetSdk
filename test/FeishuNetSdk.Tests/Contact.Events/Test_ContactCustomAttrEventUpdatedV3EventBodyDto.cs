namespace FeishuNetSdk.Tests.Contact.Events;

/// <summary>
/// 测试 成员字段变更 事件体
/// <para>接口ID：7051452465808080899</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/custom_attr/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fcustom_attr_event%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_ContactCustomAttrEventUpdatedV3EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "contact.custom_attr_event.updated_v3",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "object": {
            "contact_field_key": [
                "C-7031824249769689107","C-7033715622710083604","C-7033751091355320339","C-7046671047399047188","C-7049421473009631252","C-7027309445101125652","C-7031824013689110548","C-7033588778509795347","C-7049267281464918036","C-7046681656446435347"
            ],
            "allow_open_query": true
        },
        "old_object": {
            "contact_field_key": [
                "C-7031824249769689107","C-7033715622710083604","C-7033751091355320339","C-7046671047399047188","C-7049421473009631252","C-7027309445101125652","C-7031824013689110548","C-7033588778509795347","C-7049267281464918036","C-7046681656446435347"
            ],
            "allow_open_query": true
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Contact.Events.ContactCustomAttrEventUpdatedV3EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}