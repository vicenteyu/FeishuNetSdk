namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量创建/更新填报行 请求体
/// <para>接口ID：7446337145820069892</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batchSave-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2freport_detail_row%2fbatchSave</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ReportDetailRowBatchSaveBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "workforce_plan_id": "7435976673130317356",
    "centralized_reporting_project_id": "7436723164333753900",
    "items": [
        {
            "dimensions": [
                {
                    "dimension_key": "department",
                    "dimension_value": "7371716294248908332"
                },
                {
                    "dimension_key": "location",
                    "dimension_value": "7312702817660487212"
                },
                {
                    "dimension_key": "cost_center",
                    "dimension_value": "7212847939319219756"
                },
                {
                    "dimension_key": "job_family",
                    "dimension_value": "7210959705752192556"
                },
                {
                    "dimension_key": "employee_type",
                    "dimension_value": "7210608964277601836"
                }
            ],
            "plan_value": "919",
            "eai_details": [
                {
                    "date": "2029-01-31",
                    "estimated_active_individuals": "9"
                },
                {
                    "date": "2029-02-28",
                    "estimated_active_individuals": "99"
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ReportDetailRowBatchSaveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}