namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询编制规划明细信息（不支持自定义组织） 请求体
/// <para>接口ID：7314710843818524673</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2WorkforcePlanDetailsBatchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "workforce_plan_id": "781234834512",
    "is_centralized_reporting_project": false,
    "centralized_reporting_project_id": "7140964208476371111",
    "department_ids": [
        "7210266650427033132"
    ],
    "employee_type_ids": [
        "7210608972695520812"
    ],
    "work_location_ids": [
        "7210608972695520813"
    ],
    "job_family_ids": [
        "7210608972695520814"
    ],
    "job_level_ids": [
        "7210608972695520815"
    ],
    "job_ids": [
        "7210608972695520816"
    ],
    "cost_center_ids": [
        "7210608972695520817"
    ],
    "include_missing_dimension_rows": false
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2WorkforcePlanDetailsBatchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}