// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostDirectoryV1DepartmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 创建部门 请求体
/// <para>接口ID：7359428154233536516</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1DepartmentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department": {
        "custom_department_id": "eersdf",
        "name": {
            "default_value": "张三",
            "i18n_value": {
                "zh_cn": "中文",
                "ja_jp": "ja_jp_name",
                "en_us": "en_us_name"
            }
        },
        "parent_department_id": "h121900",
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
                            "zh_cn": "张三"
                        }
                    },
                    "url": "https://m.bytedance.com/afnasjfna",
                    "pcurl": "http://www.fs.cn"
                },
                "enum_value": {
                    "enum_ids": [
                        "dsa213sa"
                    ],
                    "enum_type": "1"
                },
                "user_values": [
                    {
                        "ids": [
                            "asdbjw1s"
                        ],
                        "user_type": "1"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1DepartmentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}