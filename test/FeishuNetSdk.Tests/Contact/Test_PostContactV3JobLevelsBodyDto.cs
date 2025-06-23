namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 创建职级 请求体
/// <para>接口ID：7194273512282423300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_level%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3JobLevelsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "高级专家",
    "description": "公司内部中高级职称，有一定专业技术能力的人员",
    "order": 200,
    "status": true,
    "i18n_name": [
        {
            "locale": "zh_cn",
            "value": "多语言内容"
        }
    ],
    "i18n_description": [
        {
            "locale": "zh_cn",
            "value": "多语言内容"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3JobLevelsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}