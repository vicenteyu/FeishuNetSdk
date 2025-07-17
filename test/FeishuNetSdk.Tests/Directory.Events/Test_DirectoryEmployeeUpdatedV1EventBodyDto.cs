// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DirectoryEmployeeUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 员工信息被修改 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 员工信息被修改 事件体
/// <para>接口ID：7419214646853140484</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_DirectoryEmployeeUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "148ea70e2d95f547a170b31c194ea9d5",
        "token": "",
        "create_time": "1726297928000",
        "event_type": "directory.employee.updated_v1",
        "tenant_key": "133c1eae3c0f1748",
        "app_id": "cli_a23f3400fe78901b"
    },
    "event": {
        "abnormal": {
            "field_errors": {
                "employee_curr.base_info.departments.department_id": 1001,
                "employee_curr.base_info.employee_order_in_departments": 1001
            },
            "row_error": 0
        },
        "changed_properties": [
            "base_info.email"
        ],
        "employee_curr": {
            "base_info": {
                "active_status": 5,
                 "avatar": {
                    "avatar_72": "https://i******le.feishu.cn/static-resource/v1/as******************************io~?image_size=72x72&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_240": "https://i******le.feishu.cn/static-resource/v1/as******************************io~?image_size=240x240&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_640": "https://i******le.feishu.cn/static-resource/v1/as******************************io~?image_size=640x640&cut_type=&quality=&format=png&sticker_format=.webp",
                    "avatar_origin": "https://i******le.feishu.cn/static-resource/v1/vas******************************io~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp"
                },
                "description": "",
                "email": "122222222@qq.com",
                "employee_id": "ou_xxxx",
                "is_resigned": false,
                "leader_id": "ou_xxxx",
                "mobile": "+86155xxxxxxxx",
                "name": {
                    "another_name": "xxxx",
                    "name": {
                        "default_value": "xxxx",
                        "i18n_value": {
                            "en_us": "",
                            "ja_jp": "",
                            "zh_cn": ""
                        }
                    }
                }
            },
            "work_info": {
                "employment_type": 1,
                "extension_number": "",
                "job_number": "",
                "job_title": {
                    "job_title_id": "0"
                },
                "join_date": "2024-07-07",
                "resign_date": "",
                "resign_reason": 0,
                "resign_remark": "",
                "resign_type": 0,
                "staff_status": 5,
                "work_country_or_region": "",
                "work_place": {
                    "place_id": "0"
                },
                "work_station": {
                    "default_value": "",
                    "i18n_value": {
                        "en_us": "",
                        "ja_jp": "",
                        "zh_cn": ""
                    }
                }
            }
        },
        "employee_prev": {
            "base_info": {
                "email": "22222222@qq.com",
                "employee_id": "ou_xxxx"
            },
            "work_info": {}
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryEmployeeUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}