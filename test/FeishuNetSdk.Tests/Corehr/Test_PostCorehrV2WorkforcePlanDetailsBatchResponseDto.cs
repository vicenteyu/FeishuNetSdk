namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询编制规划明细信息（不支持自定义组织） 响应体
/// <para>接口ID：7314710843818524673</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2WorkforcePlanDetailsBatchResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "workforce_plan_id": "7128319234123",
        "centralized_reporting_project_id": "7128319234123",
        "items": [
            {
                "workforce_plan_detail_id": "123456",
                "department": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "employee_type": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "work_location": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "job_family": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "job_level": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "job": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "cost_center": {
                    "id": "123456",
                    "name": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "workforce_plan": "10.00",
                "estimated_active_individuals_detail": [
                    {
                        "date": "2020-10-31",
                        "estimated_active_individuals": "10.00"
                    }
                ],
                "is_missing_dimension": false
            }
        ],
        "page_token": "34523459",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2WorkforcePlanDetailsBatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}