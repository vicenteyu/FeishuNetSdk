namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取租户工作城市列表 响应体
/// <para>接口ID：7256700963175038980</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/work_city/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fwork_city%2flist</para>
/// </summary>
[TestClass]
public class Test_GetContactV3WorkCitiesResponseDto : TestBase
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
                "work_city_id": "0dd1ec95f021",
                "name": "北京",
                "i18n_name": [
                    {
                        "locale": "zh_cn",
                        "value": "北京"
                    }
                ],
                "status": true
            }
        ],
        "page_token": "1r5QdASJi1sp5aJn",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3WorkCitiesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}