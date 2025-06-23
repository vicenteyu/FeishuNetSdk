namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取企业自定义用户字段 响应体
/// <para>接口ID：6986108081861476354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/custom_attr/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fcustom_attr%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3CustomAttrsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "C-6965457429001748507",
                "type": "TEXT",
                "options": {
                    "default_option_id": "qasdefgr",
                    "option_type": "TEXT",
                    "options": [
                        {
                            "id": "qasdefgr",
                            "value": "Option",
                            "name": "Name"
                        }
                    ]
                },
                "i18n_name": [
                    {
                        "locale": "zh_cn",
                        "value": "多语言内容"
                    }
                ]
            }
        ],
        "page_token": "AQD9/Rn9eij9Pm39ED40/RYU5lvOM4s6zgbeeNNaWd%2BVKwAsoreeRWk0J2noGvJy",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3CustomAttrsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}