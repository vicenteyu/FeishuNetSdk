namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 更新部门 请求体
/// <para>接口ID：7359428154233552900</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDirectoryV1DepartmentsByDepartmentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department": {
        "custom_department_id": "eedasqwA",
        "name": {
            "default_value": "张三",
            "i18n_value": {
                "zh_cn": "张三"
            }
        },
        "parent_department_id": "100",
        "leaders": [
            {
                "leader_type": 1,
                "leader_id": "u273y71"
            }
        ],
        "order_weight": "100",
        "enabled_status": true,
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
                        ],
                        "user_type": "1"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PatchDirectoryV1DepartmentsByDepartmentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}