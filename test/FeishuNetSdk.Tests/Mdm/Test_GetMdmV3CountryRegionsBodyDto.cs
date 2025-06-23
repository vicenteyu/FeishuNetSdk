namespace FeishuNetSdk.Tests.Mdm;

/// <summary>
/// 测试 分页批量查询国家/地区 请求体
/// <para>接口ID：7359131293821468674</para>
/// <para>文档地址：https://open.feishu.cn/document/mdm-v1/mdm-v3/country_region/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v3%2fcountry_region%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMdmV3CountryRegionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "filter": {
        "logic": "0",
        "expressions": [
            {
                "field": "name",
                "operator": "0",
                "value": {
                    "string_value": "安道尔",
                    "bool_value": true,
                    "int_value": "111",
                    "string_list_value": [
                        "1"
                    ],
                    "int_list_value": [
                        "1"
                    ]
                }
            }
        ]
    },
    "common": {}
}
""";
        var result = Deserialize<FeishuNetSdk.Mdm.GetMdmV3CountryRegionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}