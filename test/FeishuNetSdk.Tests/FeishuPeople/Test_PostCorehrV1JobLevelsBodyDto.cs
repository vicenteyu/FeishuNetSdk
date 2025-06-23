namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 新建职级 请求体
/// <para>接口ID：7017707615191154691</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_level%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1JobLevelsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "level_order": 9999,
    "code": "VQzo/BSonp8l6PmcZ+VlDhkd2595LMkhyBAGX6HAlCY=",
    "name": [
        {
            "lang": "zh-CN",
            "value": "初级工程师"
        }
    ],
    "description": [
        {
            "lang": "zh-CN",
            "value": "这是一个初级工程师"
        }
    ],
    "active": true,
    "custom_fields": [
        {
            "field_name": "name",
            "value": "\"Sandy\""
        }
    ],
    "job_grade": [
        "4692446793125560154"
    ],
    "pathway_ids": [
        "4719519211875096301"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1JobLevelsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}