namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询国家证件类型 响应体
/// <para>接口ID：7017707615191171075</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/national_id_type/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fnational_id_type%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1NationalIdTypesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"success",
"data":{"items":[{"id":"6888198886960137735",
"country_region_id":"6862995747139225096",
"name":[{
    "lang": "zh-CN",
    "value": "张三"
}],
"active":true,
"validation_rule":"^\\d{9}$",
"validation_rule_description":[{
    "lang": "zh-CN",
    "value": "张三"
}],
"code":"AUS-TFN",
"identification_type":{"enum_name":"type_1",
"display":[{
    "lang": "zh-CN",
    "value": "张三"
}]},
"custom_fields":[{
    "field_name": "name",
    "value": "\"Sandy\""
}]}],
"has_more":true,
"page_token":"1234452132"}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1NationalIdTypesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}