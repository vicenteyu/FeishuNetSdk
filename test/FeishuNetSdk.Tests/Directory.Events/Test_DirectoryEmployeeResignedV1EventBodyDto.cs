// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DirectoryEmployeeResignedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 员工离职 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 员工离职 事件体
/// <para>接口ID：7419214646853091332</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/resigned</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fresigned</para>
/// </summary>
[TestClass]
public class Test_DirectoryEmployeeResignedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "7c939b92cfc5c45367f4cd4c2ce082f2",
        "token": "",
        "create_time": "1726288902000",
        "event_type": "directory.employee.resigned_v1",
        "tenant_key": "133c1eae3c0f1748",
        "app_id": "cli_a23f3400fe78901b"
    },
    "event": {
        "abnormal": {
            "row_error": 0
        },
        "employee": {
            "base_info": {
                "active_status": 5,
                "avatar": {
                    "avatar_240": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=240x240&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_640": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=640x640&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_72": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=72x72&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_origin": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v3_0078_285ed6a9-53c7-4e27-8424-a3e33de9236j~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp"
                },
                "custom_field_values": [
                    {
                        "enum_value": {
                            "enum_ids": [
                                "E-xxxxx"
                            ],
                            "enum_type": 1
                        },
                        "field_key": "C-xxxxx",
                        "field_type": 3
                    }
                ],
                "departments": [
                    {
                        "department_id": "od-xxxxx"
                    }
                ],
                "description": "",
                "employee_id": "ou_xxxxx",
                "is_resigned": true,
                "leader_id": "ou_xxxxx",
                "mobile": "+86136xxxxxxxxxx",
                "name": {
                    "another_name": "xxxxx"
                }
            },
            "work_info": {
                "employment_type": 1,
                "job_number": "xxxxx"
            }
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryEmployeeResignedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}