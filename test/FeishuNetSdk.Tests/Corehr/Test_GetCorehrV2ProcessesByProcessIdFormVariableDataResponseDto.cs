namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取流程表单数据 响应体
/// <para>接口ID：7362022982036717571</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-form_variable_data%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2ProcessesByProcessIdFormVariableDataResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "field_variable_values": [
            {
                "variable_api_name": "custom123",
                "variable_name": {
                    "zh_cn": "北京",
                    "en_us": "Beijing"
                },
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
                    "user_value": "ou_c57053dad6eea0aea4696c48433d8562",
                    "department_value": "od-a761814f6bc3f14bd3b00905ec1d7c6f",
                    "record_values": [
                        {
                            "variable_api_name": "city_v2",
                            "sub_value_key": "key1"
                        }
                    ],
                    "employment_value": "ou_c57053dad6eea0aea4696c48433d8562",
                    "list_values": [
                        "key1"
                    ],
                    "file_value": {
                        "open_file_id": "66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53",
                        "file_name": "file_name",
                        "length": "65535",
                        "mime_type": "application/pdf"
                    }
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
                            "user_value": "ou_c57053dad6eea0aea4696c48433d8562",
                            "department_value": "od-a761814f6bc3f14bd3b00905ec1d7c6f",
                            "record_values": [
                                {
                                    "variable_api_name": "city_v2",
                                    "sub_value_key": "key1"
                                }
                            ],
                            "employment_value": "ou_c57053dad6eea0aea4696c48433d8562",
                            "list_values": [
                                "key1"
                            ],
                            "file_value": {
                                "open_file_id": "66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53",
                                "file_name": "file_name",
                                "length": "65535",
                                "mime_type": "application/pdf"
                            }
                        }
                    }
                ]
            }
        ],
        "process_id": "7368832822481536556"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2ProcessesByProcessIdFormVariableDataResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}