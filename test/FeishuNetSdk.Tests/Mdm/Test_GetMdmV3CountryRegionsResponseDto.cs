// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMdmV3CountryRegionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 分页批量查询国家/地区 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mdm;

/// <summary>
/// 测试 分页批量查询国家/地区 响应体
/// <para>接口ID：7359131293821468674</para>
/// <para>文档地址：https://open.feishu.cn/document/mdm-v1/mdm-v3/country_region/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v3%2fcountry_region%2flist</para>
/// </summary>
[TestClass]
public class Test_GetMdmV3CountryRegionsResponseDto : TestBase
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
                        "zh-CN": "安道尔"
                    }
                }
            }
        ],
        "total": "0",
        "next_page_token": "token"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Mdm.GetMdmV3CountryRegionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}