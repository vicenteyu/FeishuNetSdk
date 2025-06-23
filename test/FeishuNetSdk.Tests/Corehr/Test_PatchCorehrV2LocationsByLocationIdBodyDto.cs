namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新地点 请求体
/// <para>接口ID：7420421437192962051</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2LocationsByLocationIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "parent_id": "4719168654814483759",
    "names": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "active": true,
    "effective_time": "2020-05-02",
    "code": "12456",
    "descriptions": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "location_usages": [
        {
            "enum_name": "phone_type"
        }
    ],
    "working_hours_type_id": "4690238309151997779",
    "locale": {
        "enum_name": "phone_type"
    },
    "time_zone_id": "123456789",
    "display_language_id": "123456789"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2LocationsByLocationIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}