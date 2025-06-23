namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询兼职信息 响应体
/// <para>接口ID：7387981900317589506</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-additional_job/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-additional_job%2fbatch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesAdditionalJobsBatchResponseDto : TestBase
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
                "id": "6890452208593372679",
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
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "compensation_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "service_company": "6890452208593372680",
                "weekly_working_hours": "5",
                "work_calendar_id": "6890452208593372680",
                "position_id": "6890452208593372680",
                "employee_subtype_id": "6890452208593372680"
            }
        ],
        "page_token": "Njg5MTI1MTcyMjYzMTg5MDQ0NQ==",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2EmployeesAdditionalJobsBatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}