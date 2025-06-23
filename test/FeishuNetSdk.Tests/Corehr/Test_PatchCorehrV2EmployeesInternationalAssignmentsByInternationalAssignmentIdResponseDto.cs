namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新外派信息 响应体
/// <para>接口ID：7446683431818412035</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-international_assignment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-international_assignment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2EmployeesInternationalAssignmentsByInternationalAssignmentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "international_assignment": {
            "work_location_id": "7127921432117937708",
            "service_company": "7127921432117937708",
            "work_shift": {
                "enum_name": "phone_type",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
            "working_hours_type_id": "7127921432117937708",
            "employee_type_id": "7127921432117937708",
            "weekly_working_hours_v2": 8,
            "department_id": "7127921432117937708",
            "job_id": "7127921432117937708",
            "job_family_id": "7127921432117937708",
            "job_level_id": "7127921432117937708",
            "job_grade_id": "7127921432117937708",
            "compensation_type": {
                "enum_name": "phone_type",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
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
            "international_assignment_status": {
                "enum_name": "phone_type",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
            "international_assignment_type": {
                "enum_name": "phone_type",
                "display": [
                    {
                        "lang": "zh-CN",
                        "value": "中文示例"
                    }
                ]
            },
            "effective_time": "2024-01-02",
            "expiration_time": "2024-01-02",
            "id": "7127921432117937708"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PatchCorehrV2EmployeesInternationalAssignmentsByInternationalAssignmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}