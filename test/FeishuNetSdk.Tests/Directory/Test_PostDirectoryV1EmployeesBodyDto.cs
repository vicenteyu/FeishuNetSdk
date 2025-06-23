namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 创建员工 请求体
/// <para>接口ID：7359428154233651204</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employee": {
        "name": {
            "last_name": {
                "default_value": "张三",
                "i18n_value": {
                    "zh_cn": "中文",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_us_name"
                }
            },
            "first_name": {
                "default_value": "张三",
                "i18n_value": {
                    "zh_cn": "中文",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_us_name"
                }
            },
            "name": {
                "default_value": "张三",
                "i18n_value": {
                    "zh_cn": "中文",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_us_name"
                }
            },
            "another_name": "jack"
        },
        "mobile": "13011111111 或 +8613011111111",
        "custom_employee_id": "u273y71",
        "avatar_key": "8abc397a-9950-44ea-9302-e1d8fe00858g",
        "email": "zhangsan@gmail.com",
        "enterprise_email": "zhangsan@gmail.com",
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
                "zh_cn": "中文",
                "ja_jp": "ja_jp_name",
                "en_us": "en_us_name"
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
                "field_type": "3",
                "text_value": {
                    "default_value": "张三",
                    "i18n_value": {
                        "zh_cn": "中文",
                        "ja_jp": "ja_jp_name",
                        "en_us": "en_us_name"
                    }
                },
                "url_value": {
                    "link_text": {
                        "default_value": "张三",
                        "i18n_value": {
                            "zh_cn": "中文",
                            "ja_jp": "ja_jp_name",
                            "en_us": "en_us_name"
                        }
                    },
                    "url": "https://m.bytedance.com/afnasjfna",
                    "pcurl": "http://www.fs.cn"
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
                        ],
                        "user_type": "1"
                    }
                ],
                "field_key": "C-1000001"
            }
        ]
    },
    "options": {
        "geo_name": "cn",
        "subscription_ids": [
            "123123123"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1EmployeesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}