// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1CustomFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自定义字段列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 获取自定义字段列表 响应体
/// <para>接口ID：7112009113388122140</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcustom_field%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1CustomFieldsQueryResponseDto : TestBase
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
                "custom_api_name": "custom_field_33__c",
                "name": {
                    "zh_cn": "cn",
                    "en_us": "en"
                },
                "description": {
                    "zh_cn": "cn",
                    "en_us": "en"
                },
                "is_open": true,
                "is_required": true,
                "is_unique": true,
                "object_api_name": "offboarding_info",
                "type": 1,
                "common_schema_config": {
                    "text_field_setting": {
                        "is_multilingual": true,
                        "is_multiline": true,
                        "max_length": 1,
                        "is_url_type": true
                    },
                    "number_field_setting": {
                        "number_field_type": 1,
                        "decimal_places": 1,
                        "round_type": 1,
                        "decimal_total_places": 1
                    },
                    "enum_field_setting": {
                        "enum_field_option_list": [
                            {
                                "api_name": "custom_enum_option_33",
                                "name": {
                                    "zh_cn": "cn",
                                    "en_us": "en"
                                },
                                "description": {
                                    "zh_cn": "cn",
                                    "en_us": "en"
                                },
                                "is_open": true
                            }
                        ],
                        "is_multiple": false
                    },
                    "lookup_field_setting": {
                        "lookup_obj_api_name": "employment",
                        "is_multiple": false
                    },
                    "date_time_field_setting": {
                        "date_time_type": 1
                    },
                    "attachment_field_setting": {
                        "is_multiple": false,
                        "file_type": 1
                    },
                    "image_field_setting": {
                        "image_type": 1,
                        "display_style": 1
                    },
                    "calculated_field_setting": {
                        "type": 1
                    }
                },
                "create_time": "1625542287",
                "update_time": "1625542639"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1CustomFieldsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}