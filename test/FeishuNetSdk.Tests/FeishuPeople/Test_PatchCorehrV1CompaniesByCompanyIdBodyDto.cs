namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新公司 请求体
/// <para>接口ID：7309323790810824705</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcompany%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1CompaniesByCompanyIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "hiberarchy_common": {
        "parent_id": "4719168654814483759",
        "name": [
            {
                "lang": "zh-CN",
                "value": "xx有限科技公司"
            }
        ],
        "active": true,
        "effective_time": "2020-05-01 00:00:00",
        "code": "12456",
        "description": [
            {
                "lang": "zh-CN",
                "value": "xx有限科技公司"
            }
        ]
    },
    "type": {
        "enum_name": "private_owned"
    },
    "industry_list": [
        {
            "enum_name": "professional_technique_service"
        }
    ],
    "legal_representative": [
        {
            "lang": "zh-CN",
            "value": "张三"
        }
    ],
    "post_code": "邮编",
    "tax_payer_id": "123456840",
    "confidential": true,
    "sub_type_list": [
        {
            "enum_name": "company"
        }
    ],
    "branch_company": true,
    "primary_manager": [
        {
            "lang": "zh-CN",
            "value": "张三"
        }
    ],
    "currency": {
        "currency_name": [
            {
                "lang": "zh-CN",
                "value": "xx科技有限公司"
            }
        ],
        "numeric_code": 12,
        "currency_alpha_3_code": "CNY"
    },
    "phone": {
        "area_code": {
            "enum_name": "86_china"
        },
        "phone_number": "213213"
    },
    "fax": {
        "area_code": {
            "enum_name": "86_china"
        },
        "phone_number": "213213"
    },
    "registered_office_address_info": {
        "country_region_id": "6862995757234914824",
        "region_id": "6863326815667095047",
        "city_id": "6863333254578046471",
        "distinct_id": "6863333516579440141",
        "address_line1": "丹佛测试地址-纽埃时区",
        "address_line2": "PoewH",
        "address_line3": "PoewH",
        "address_line4": "jmwJc",
        "address_line5": "jmwJc",
        "address_line6": "jmwJc",
        "address_line7": "jmwJc",
        "address_line8": "rafSu",
        "address_line9": "McPRG",
        "local_address_line1": "丹佛测试地址-纽埃时区",
        "local_address_line2": "PoewH",
        "local_address_line3": "PoewH",
        "local_address_line4": "jmwJc",
        "local_address_line5": "jmwJc",
        "local_address_line6": "jmwJc",
        "local_address_line7": "jmwJc",
        "local_address_line8": "rafSu",
        "local_address_line9": "McPRG",
        "postal_code": "611530"
    },
    "office_address_info": {
        "country_region_id": "6862995757234914824",
        "region_id": "6863326815667095047",
        "city_id": "6863333254578046471",
        "distinct_id": "6863333516579440141",
        "address_line1": "丹佛测试地址-纽埃时区",
        "address_line2": "PoewH",
        "address_line3": "PoewH",
        "address_line4": "jmwJc",
        "address_line5": "jmwJc",
        "address_line6": "jmwJc",
        "address_line7": "jmwJc",
        "address_line8": "rafSu",
        "address_line9": "McPRG",
        "local_address_line1": "丹佛测试地址-纽埃时区",
        "local_address_line2": "PoewH",
        "local_address_line3": "PoewH",
        "local_address_line4": "jmwJc",
        "local_address_line5": "jmwJc",
        "local_address_line6": "jmwJc",
        "local_address_line7": "jmwJc",
        "local_address_line8": "rafSu",
        "local_address_line9": "McPRG",
        "postal_code": "611530"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PatchCorehrV1CompaniesByCompanyIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}