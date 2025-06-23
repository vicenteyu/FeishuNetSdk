namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 批量获取部门信息 响应体
/// <para>接口ID：7359428234122854404</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1DepartmentsMgetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "departments": [
            {
                "department_id": "h12921",
                "department_count": {
                    "recursive_members_count": "100",
                    "direct_members_count": "100",
                    "recursive_members_count_exclude_leaders": "100",
                    "recursive_departments_count": "100",
                    "direct_departments_count": "100"
                },
                "has_child": true,
                "leaders": [
                    {
                        "leader_type": 1,
                        "leader_id": "u273y71"
                    }
                ],
                "parent_department_id": "h12921",
                "name": {
                    "default_value": "张三",
                    "i18n_value": {
                        "zh_cn": "中文",
                        "ja_jp": "ja_jp_name",
                        "en_us": "en_us_name"
                    }
                },
                "enabled_status": true,
                "order_weight": "无",
                "custom_field_values": [
                    {
                        "field_key": "C-1000001",
                        "field_type": "1",
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
                                "1"
                            ],
                            "enum_type": "1"
                        },
                        "user_values": [
                            {
                                "ids": [
                                    "1"
                                ]
                            }
                        ]
                    }
                ],
                "department_path_infos": [
                    {
                        "department_id": "1",
                        "department_name": {
                            "default_value": "张三",
                            "i18n_value": {
                                "zh_cn": "中文",
                                "ja_jp": "ja_jp_name",
                                "en_us": "en_us_name"
                            }
                        }
                    }
                ],
                "data_source": 1
            }
        ],
        "abnormals": [
            {
                "id": "eedasfwe",
                "row_error": 0,
                "field_errors": {
                    "name": 1000
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.PostDirectoryV1DepartmentsMgetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}