namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 更新员工 请求体
/// <para>接口ID：7359428154233667588</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDirectoryV1EmployeesByEmployeeIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employee": {
        "name": {
            "name": {
                "default_value": "张三",
                "i18n_value": {
                    "zh_cn": "张三",
                    "ja_jp": "佐藤はるか",
                    "en_us": "Alex Zhang"
                }
            },
            "another_name": "Jack"
        },
        "mobile": "+8613011111111",
        "custom_employee_id": "u273y71",
        "avatar_key": "8abc397a-9950-44ea-9302-e1d8fe00858g",
        "email": "zhangsan@test.com",
        "enterprise_email": "zhangsan@test.com",
        "gender": "1",
        "employee_order_in_departments": [
            {
                "department_id": "0",
                "order_weight_in_deparment": "100",
                "order_weight_among_deparments": "20",
                "is_main_department": false
            }
        ],
        "leader_id": "eeasdqwwe",
        "dotted_line_leader_ids": [
            "hdsuqw"
        ],
        "work_country_or_region": "MDM34234234",
        "work_place_id": "eqwedas",
        "work_station": {
            "default_value": "张三",
            "i18n_value": {
                "zh_cn": "工位",
                "ja_jp": "工位",
                "en_us": "Work Station"
            }
        },
        "job_number": "2845435",
        "extension_number": "2845435",
        "join_date": "2022-10-10",
        "employment_type": "1",
        "staff_status": "",
        "job_title_id": "wqedsaqw",
        "resign_reason": "",
        "resign_type": "",
        "custom_field_values": [
            {
                "field_type": "1",
                "text_value": {
                    "default_value": "姓名字段",
                    "i18n_value": {
                        "zh_cn": "姓名字段",
                        "ja_jp": "姓名字段",
                        "en_us": "Name Filed"
                    }
                },
                "url_value": {
                    "link_text": {
                        "default_value": "网页地址",
                        "i18n_value": {
                            "zh_cn": "网页地址",
                            "ja_jp": "This is a URL",
                            "en_us": "This is a URL"
                        }
                    },
                    "url": "https://www.feishu.cn/",
                    "pcurl": "https://www.feishu.cn/"
                },
                "enum_value": {
                    "enum_ids": [
                        "75ec5g97"
                    ],
                    "enum_type": "1"
                },
                "user_values": [
                    {
                        "ids": [
                            "27al2hef"
                        ]
                ],
                "field_key": "C-1000001"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PatchDirectoryV1EmployeesByEmployeeIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}