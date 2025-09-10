// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2JobChangesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 发起员工异动 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 发起员工异动 响应体
/// <para>接口ID：7449328616456601619</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2JobChangesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "job_change_id": "6991776076699549697",
        "employment_id": "ou_a294793e8fa21529f2a60e3e9de45520",
        "status": "Approved",
        "transfer_type_unique_identifier": "direct_leader_change",
        "transfer_reason_unique_identifier": "involuntary_transfer",
        "process_id": "6991776078461142564",
        "effective_date": "2022-03-01",
        "created_time": "1627899724000",
        "transfer_info": {
            "remark": "异动详情",
            "offer_info": "优质人才，加急处理",
            "target_dotted_manager_clean": false,
            "probation_exist": true,
            "original_department": "6966236933198579208",
            "target_department": "6966236933198579208",
            "original_work_location": "6967271100992587295",
            "target_work_location": "6967271100992587295",
            "original_direct_manager": "6974641477444060708",
            "target_direct_manager": "7013619729281713671",
            "original_dotted_manager": "6974648866876573198",
            "target_dotted_manager": "7013328578351842852",
            "original_job": "6969469398088287751",
            "target_job": "6969469557836760606",
            "original_job_family": "6967287547462419975",
            "target_job_family": "6967287547462419975",
            "original_job_level": "6972085707674355214",
            "target_job_level": "6972085707674355214",
            "original_workforce_type": "6968386026792289828",
            "target_workforce_type": "7036268995372303885",
            "original_employee_subtype": "6968386026792289828",
            "target_employee_subtype": "7036268995372303885",
            "original_company": "6974659700705068581",
            "target_company": "6974659700705068581",
            "original_contract_number": "55332",
            "target_contract_number": "55333",
            "original_contract_type": "labor_contract",
            "target_contract_type": "labor_contract",
            "original_duration_type": "fixed_term",
            "target_duration_type": "fixed_term",
            "original_signing_type": "new",
            "target_signing_type": "new",
            "original_contract_start_date": "2021-07-01",
            "target_contract_start_date": "2021-07-01",
            "original_contract_end_date": "2024-07-01",
            "target_contract_end_date": "2024-07-01",
            "original_working_hours_type": "6969087376740206087",
            "target_working_hours_type": "6969087376740206087",
            "original_working_calendar": "6969087376740236087",
            "target_working_calendar": "6969087376740236087",
            "original_probation_end_date": "2021-11-17",
            "target_probation_end_date": "2021-11-17",
            "original_weekly_working_hours": "162",
            "target_weekly_working_hours": "160",
            "original_work_shift": "work_shift",
            "target_work_shift": "non_work_shift",
            "original_cost_center_rate": [
                {
                    "cost_center_id": "6950635856373745165",
                    "rate": 100
                }
            ],
            "target_cost_center_rate": [
                {
                    "cost_center_id": "6950635856373745165",
                    "rate": 100
                }
            ],
            "original_employment_change": {
                "regular_employee_start_date": "2023-01-01",
                "seniority_date": "2023-01-01",
                "employee_number": "1111111",
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ]
            },
            "target_employment_change": {
                "regular_employee_start_date": "2023-01-01",
                "seniority_date": "2023-01-01",
                "employee_number": "1111111",
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ]
            },
            "original_job_grade": "7289005963599693366",
            "target_job_grade": "7289005963599693366",
            "original_compensation_type": "hourly",
            "target_compensation_type": "salary",
            "original_service_company": "7289005963599693367",
            "target_service_company": "7289005963599693367",
            "original_position": "7289005963599693367",
            "target_position": "7289005963599693367",
            "original_social_security_city": "7289005963599693367",
            "target_social_security_city": "7289005963599693367",
            "original_pathway": "7289005963599693367",
            "target_pathway": "7289005963599693367",
            "is_transfer_with_workforce": false
        },
        "is_adjust_salary": true,
        "custom_fields": [
            {
                "custom_api_name": "name",
                "name": {
                    "zh_cn": "自定义姓名",
                    "en_us": "Custom Name"
                },
                "type": 1,
                "value": "\"231\""
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2JobChangesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}