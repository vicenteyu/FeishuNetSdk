namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单个工时制度 响应体
/// <para>接口ID：7017707615190908931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/working_hours_type/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fworking_hours_type%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1WorkingHoursTypesByWorkingHoursTypeIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "working_hours_type": {
            "id": "6890452208593372679",
            "code": "1",
            "name": [
                {
                    "lang": "zh-CN",
                    "value": "张三"
                }
            ],
            "country_region_id_list": [
                "6890452208593356295"
            ],
            "default_for_job": true,
            "active": true,
            "custom_fields": [
                {
                    "field_name": "name",
                    "value": "\"Sandy\""
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1WorkingHoursTypesByWorkingHoursTypeIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}