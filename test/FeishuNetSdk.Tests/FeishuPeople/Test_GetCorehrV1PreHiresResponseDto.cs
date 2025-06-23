namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询待入职信息 响应体
/// <para>接口ID：7017707615190958083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/pre_hire/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fpre_hire%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1PreHiresResponseDto : TestBase
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
                "ats_application_id": "4719168654814483759",
                "id": "154545454",
                "hire_date": "2020-01-01",
                "employee_type": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "worker_id": "1245646",
                "employee_type_id": "正式",
                "person_id": "656464648662",
                "custom_fields": [
                    {
                        "field_name": "name",
                        "value": "\"Sandy\""
                    }
                ],
                "onboarding_status": {
                    "enum_name": "type_1",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "cost_center_rate": [
                    {
                        "cost_center_id": "6950635856373745165",
                        "rate": 100
                    }
                ],
                "work_email_list": [
                    {
                        "email": "12456@test.com",
                        "is_primary": true,
                        "is_public": true,
                        "email_usage": {
                            "enum_name": "type_1",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "custom_fields": [
                            {
                                "field_name": "name",
                                "value": "\"Sandy\""
                            }
                        ]
                    }
                ],
                "department_id": "656464648662"
            }
        ],
        "has_more": true,
        "page_token": "1234452132"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1PreHiresResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}