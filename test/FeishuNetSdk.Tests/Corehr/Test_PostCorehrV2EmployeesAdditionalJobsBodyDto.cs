namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建兼职 请求体
/// <para>接口ID：7387981900317540354</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-additional_job/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-additional_job%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesAdditionalJobsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employee_type_id": "6890452208593372679",
    "working_hours_type_id": "6890452208593372679",
    "work_location_id": "6890452208593372679",
    "department_id": "6890452208593372679",
    "job_id": "6890452208593372679",
    "job_level_id": "6890452208593372679",
    "job_family_id": "1245678",
    "employment_id": "6893014062142064135",
    "start_date": "2020-05-01",
    "end_date": "2020-05-02",
    "direct_manager_id": "6890452208593372680",
    "dotted_line_manager_id": "6890452208593372680",
    "work_shift": {
        "enum_name": "phone_type"
    },
    "compensation_type": {
        "enum_name": "phone_type"
    },
    "service_company": "6890452208593372680",
    "weekly_working_hours": "5",
    "work_calendar_id": "6890452208593372680",
    "position_id": "6890452208593372680",
    "employee_subtype_id": "6890452208593372680"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesAdditionalJobsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}