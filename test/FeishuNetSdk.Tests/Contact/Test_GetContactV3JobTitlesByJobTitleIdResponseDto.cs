namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取单个职务信息 响应体
/// <para>接口ID：7256700963174989828</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/job_title/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_title%2fget</para>
/// </summary>
[TestClass]
public class Test_GetContactV3JobTitlesByJobTitleIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_title": {
            "job_title_id": "b5565c46b749",
            "name": "高级工程师",
            "i18n_name": [
                {
                    "locale": "zh_cn",
                    "value": "专家"
                }
            ],
            "status": true
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3JobTitlesByJobTitleIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}