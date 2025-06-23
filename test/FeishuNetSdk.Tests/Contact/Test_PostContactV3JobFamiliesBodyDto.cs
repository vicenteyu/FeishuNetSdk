namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 创建序列 请求体
/// <para>接口ID：7194273514093412356</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_family/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_family%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3JobFamiliesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "产品",
    "description": "负责产品策略制定的相关工作",
    "parent_job_family_id": "mga5oa8ayjlpzjq",
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
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3JobFamiliesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}