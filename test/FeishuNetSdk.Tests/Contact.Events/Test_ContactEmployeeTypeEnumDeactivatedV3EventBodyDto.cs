namespace FeishuNetSdk.Tests.Contact.Events;

/// <summary>
/// 测试 停用人员类型 事件体
/// <para>接口ID：6985055606752526364</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/events/deactivated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fevents%2fdeactivated</para>
/// </summary>
[TestClass]
public class Test_ContactEmployeeTypeEnumDeactivatedV3EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "contact.employee_type_enum.deactivated_v3",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "old_enum": {
            "enum_id": "exGeIjow7zIqWMy+ONkFxA==",
            "enum_value": "2",
            "content": "专家",
            "enum_type": 2,
            "enum_status": 1,
            "i18n_content": [
                {
                    "locale": "zh_cn",
                    "value": "多语言内容"
                }
            ]
        },
        "new_enum": {
            "enum_id": "exGeIjow7zIqWMy+ONkFxA==",
            "enum_value": "2",
            "content": "专家",
            "enum_type": 2,
            "enum_status": 1,
            "i18n_content": [
                {
                    "locale": "zh_cn",
                    "value": "多语言内容"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Contact.Events.ContactEmployeeTypeEnumDeactivatedV3EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}