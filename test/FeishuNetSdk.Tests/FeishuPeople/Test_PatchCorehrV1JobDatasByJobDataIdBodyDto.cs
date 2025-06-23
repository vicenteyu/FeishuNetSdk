namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新任职信息 请求体
/// <para>接口ID：7072642400195723292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/job_data/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1JobDatasByJobDataIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "version_id": "6890452208593372697",
    "job_level_id": "6890452208593372679",
    "job_grade_id": "6890452208593372679",
    "employee_type_id": "6890452208593372679",
    "working_hours_type_id": "6890452208593372679",
    "work_location_id": "6890452208593372679",
    "department_id": "6890452208593372679",
    "job_id": "6890452208593372679",
    "probation_start_date": "2018-03-16",
    "probation_end_date": "2019-05-24",
    "primary_job_data": true,
    "effective_time": "2020-05-01 00:00:00",
    "expiration_time": "2020-05-02 00:00:00",
    "job_family_id": "1245678",
    "assignment_start_reason": {
        "enum_name": "job_status_change"
    },
    "probation_expected_end_date": "2006-01-02",
    "direct_manager_id": "6890452208593372679",
    "dotted_line_manager_id_list": [
        "6890452208593372681"
    ],
    "second_direct_manager_id": "6890452208593372679",
    "cost_center_rate": [
        {
            "cost_center_id": "6950635856373745165",
            "rate": 100
        }
    ],
    "work_shift": {
        "enum_name": "example"
    },
    "compensation_type": {
        "enum_name": "example"
    },
    "service_company": "6890452208593372680",
    "pathway_id": "6890452208593372671"
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PatchCorehrV1JobDatasByJobDataIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}