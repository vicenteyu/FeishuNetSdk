namespace FeishuNetSdk.Tests.Mdm;

/// <summary>
/// 测试 根据主数据编码批量查询国家/地区 响应体
/// <para>接口ID：7359131293821452290</para>
/// <para>文档地址：https://open.feishu.cn/document/mdm-v1/mdm-v3/country_region/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v3%2fbatch_country_region%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMdmV3BatchCountryRegionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data": [
            {
                "alpha_3_code": "AND",
                "alpha_2_code": "AD",
                "numeric_code": "20",
                "name": {
                    "value": "安道尔",
                    "multilingual_value": {
                        "zh-CN": "安道尔"
                    },
                    "return_language": "zh-CN"
                },
                "mdm_code": "MDCT00000001",
                "full_name": {
                    "value": "安道尔公国",
                    "multilingual_value": {
                        "zh-CN": "安道尔公国"
                    },
                    "return_language": "zh-CN"
                },
                "global_code": "+376",
                "status": "1",
                "continents": {
                    "value": "2",
                    "multilingual_name": {
                        "zh-CN": "欧洲"
                    }
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mdm.GetMdmV3BatchCountryRegionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}