// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1SocialArchiveQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取员工参保档案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量获取员工参保档案 响应体
/// <para>接口ID：7420038908975398914</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1SocialArchiveQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "archives": [
            {
                "user_id": "9960875",
                "details": [
                    {
                        "description": {
                            "zh_cn": "中文名称",
                            "en_us": "Social Insurance Contribution Record"
                        },
                        "insurance_type": "social_insurance",
                        "insurance_status": "contribution",
                        "id": "7202347584043501100",
                        "tid": "7202347584043566636",
                        "plan_id": "7200668421690885676",
                        "plan_tid": "7200668421690852908",
                        "location_id": "7152398273176192556",
                        "company_id": "7096372135576618540",
                        "account_type": "associated_company",
                        "insurance_account": "ac123456",
                        "base_salary": "1000.10",
                        "insurance_details": [
                            {
                                "insurance_id": "111223",
                                "company_deduction": "2000.20",
                                "company_setting": {
                                    "lower_limit": "1000.00",
                                    "upper_limit": "2000.00",
                                    "payment_ratio": "8.00",
                                    "payment_rounding_rule": "round_down",
                                    "payment_decimals": 2,
                                    "fixed_payment": "200.00"
                                },
                                "personal_deduction": "1000.20",
                                "personal_setting": {
                                    "lower_limit": "1000.00",
                                    "upper_limit": "2000.00",
                                    "payment_ratio": "8.00",
                                    "payment_rounding_rule": "round_up",
                                    "payment_decimals": 2,
                                    "fixed_payment": "200.00"
                                },
                                "payment_frequency": "monthly",
                                "payment_months": [
                                    1
                                ]
                            }
                        ],
                        "effective_date": "2024-01-01"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1SocialArchiveQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}