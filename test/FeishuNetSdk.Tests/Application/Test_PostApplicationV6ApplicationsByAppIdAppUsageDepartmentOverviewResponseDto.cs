namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取多部门应用使用概览 响应体
/// <para>接口ID：7036626399368937500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/department_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fdepartment_overview</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": false,
        "items": [
            {
                "department_id": "7a59bc779b7c1f19",
                "app": [
                    {
                        "metric_name": "uv",
                        "metric_value": 141121
                    },
                    {
                        "metric_name": "total_users",
                        "metric_value": 141123
                    },
                    {
                        "metric_name": "new_users",
                        "metric_value": 141122
                    },
                    {
                        "metric_name": "pv",
                        "metric_value": 141122
                    },
                    {
                        "metric_name": "lifecycle",
                        "metric_value": 141122
                    }
                ],
                "gadget": [
                    {
                        "metric_name": "uv",
                        "metric_value": 141124
                    },
                    {
                        "metric_name": "pv",
                        "metric_value": 141122
                    },
                    {
                        "metric_name": "lifecycle",
                        "metric_value": 141122
                    }
                ],
                "webapp": [
                    {
                        "metric_name": "uv",
                        "metric_value": 141127
                    },
                    {
                        "metric_name": "pv",
                        "metric_value": 141122
                    },
                    {
                        "metric_name": "lifecycle",
                        "metric_value": 141122
                    }
                ]
            },
            {
                "app": [
                    {
                        "metric_name": "uv",
                        "metric_value": 0
                    }
                ],
                "department_id": "33a1ec888371b1f8"
            }
        ],
        "page_token": ""
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}