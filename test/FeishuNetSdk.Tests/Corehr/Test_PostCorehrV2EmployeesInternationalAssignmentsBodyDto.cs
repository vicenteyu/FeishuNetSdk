// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2EmployeesInternationalAssignmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建外派信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建外派信息 请求体
/// <para>接口ID：7446683431818395651</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-international_assignment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-international_assignment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesInternationalAssignmentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "work_location_id": "7127921432117937708",
    "service_company": "7127921432117937708",
    "work_shift": "work_shift",
    "weekly_working_hours_v2": 8,
    "working_hours_type_id": "7127921432117937708",
    "employee_type_id": "7127921432117937708",
    "department_id": "7127921432117937708",
    "job_id": "7127921432117937708",
    "job_family_id": "7127921432117937708",
    "job_level_id": "7127921432117937708",
    "job_grade_id": "7127921432117937708",
    "compensation_type": "daily",
    "direct_manager_id": "7127921432117937708",
    "dotted_line_manager_id": "7127921432117937708",
    "work_calendar_id": "7127921432117937708",
    "position_id": "7127921432117937708",
    "employment_id": "7127921432117937708",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "Sandy"
        }
    ],
    "international_assignment_reason": "xxx 项目派遣",
    "description": "xxx 项目",
    "international_assignment_expected_end_date": "2024-01-02",
    "international_assignment_type": "global_assignment",
    "effective_time": "2024-01-02",
    "expiration_time": "2024-01-02"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesInternationalAssignmentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}