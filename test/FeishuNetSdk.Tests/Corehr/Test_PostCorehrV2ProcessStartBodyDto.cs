// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-02-06
//
// Last Modified By : yxr
// Last Modified On : 2026-02-06
// ************************************************************************
// <copyright file="Test_PostCorehrV2ProcessStartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发起流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 发起流程 请求体
/// <para>接口ID：7451908159096766468</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess_start%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ProcessStartBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "flow_definition_id": "people_7023711013443944467_7437160904904494892",
    "initiator_id": "ou_91791271921729102012",
    "system_initiator": true,
    "flow_data": [
        {
            "variable_api_name": "custom123",
            "variable_value": {
                "text_value": "测试测试",
                "bool_value": true,
                "number_value": "100",
                "enum_value": "home_address",
                "date_value": "19838",
                "date_time_value": "1714013877512",
                "i18n_value": {
                    "zh_cn": "北京",
                    "en_us": "Beijing"
                },
                "object_value": {
                    "wk_id": "6863326263210149383",
                    "wk_api_name": "country_region_subdivision"
                },
                "department_value": "od-a761814f6bc3f14bd3b00905ec1d7c6f",
                "employment_value": "ou_c57053dad6eea0aea4696c48433d8562",
                "list_values": [
                    "key1"
                ],
                "file_value": {
                    "open_file_id": "66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53",
                    "file_name": "file_name.jpg",
                    "length": 65535
                },
                "record_values": [
                    {
                        "variable_api_name": "city_v2",
                        "sub_value_key": "key1",
                        "record_id": "6863326263210149383"
                    }
                ]
            },
            "sub_values": [
                {
                    "key": "key1",
                    "value": {
                        "text_value": "测试测试",
                        "bool_value": true,
                        "number_value": "100",
                        "enum_value": "home_address",
                        "date_value": "19838",
                        "date_time_value": "1714013877512",
                        "i18n_value": {
                            "zh_cn": "北京",
                            "en_us": "Beijing"
                        },
                        "object_value": {
                            "wk_id": "6863326263210149383",
                            "wk_api_name": "country_region_subdivision"
                        },
                        "department_value": "od-a761814f6bc3f14bd3b00905ec1d7c6f",
                        "employment_value": "ou_c57053dad6eea0aea4696c48433d8562",
                        "list_values": [
                            "key1"
                        ],
                        "file_value": {
                            "open_file_id": "66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53",
                            "file_name": "file_name.jpg",
                            "length": 65535
                        },
                        "record_values": [
                            {
                                "variable_api_name": "city_v2",
                                "sub_value_key": "key1",
                                "record_id": "6863326263210149383"
                            }
                        ]
                    }
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ProcessStartBodyDto>(json);
        Assert.IsNotNull(result);
    }
}