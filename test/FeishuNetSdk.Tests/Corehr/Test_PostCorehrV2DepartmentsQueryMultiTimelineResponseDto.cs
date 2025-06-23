namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门版本信息 响应体
/// <para>接口ID：7372158581884911618</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_multi_timeline</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsQueryMultiTimelineResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "4719456877659520852",
                "version_id": "7238516215202170412",
                "names": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "sub_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "parent_department_id": "4719456877659520111",
                "manager": "6893013238632416777",
                "code": "D00000456",
                "effective_date": "2020-05-01",
                "active": true,
                "descriptions": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ],
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsQueryMultiTimelineResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}