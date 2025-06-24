namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建国家证件类型 响应体
/// <para>接口ID：7072646286193786908</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/national_id_type/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fnational_id_type%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1NationalIdTypesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"code":0,
"msg":"success",
"data":{"national_id_type":{"id":"6888198886960137735",
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
}]}}}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.PostCorehrV1NationalIdTypesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}