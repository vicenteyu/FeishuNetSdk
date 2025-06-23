namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 通过/拒绝审批任务 请求体
/// <para>接口ID：7340625370520797187</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/approver-task/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-approver%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutCorehrV2ProcessesByProcessIdApproversByApproverIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "status": 2,
    "user_id": "ou_91791271921729102012",
    "system_approval": true,
    "reason": "原因自定义字符串",
    "field_values_v2": [
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
                    "file_name": "file_name",
                    "length": 65535
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
                        "department_value": "od-a761814f6bc3f14bd3b00905ec1d7c6f",
                        "employment_value": "ou_c57053dad6eea0aea4696c48433d8562",
                        "list_values": [
                            "key1"
                        ],
                        "file_value": {
                            "open_file_id": "66867ed00740ddd4a0bad4a5_c99b5322dc744fe4b99b76426ffe5d53",
                            "file_name": "file_name",
                            "length": 65535
                        }
                    }
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PutCorehrV2ProcessesByProcessIdApproversByApproverIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}