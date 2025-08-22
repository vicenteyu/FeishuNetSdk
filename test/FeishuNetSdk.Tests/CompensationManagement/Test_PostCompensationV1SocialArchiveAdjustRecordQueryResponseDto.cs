// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1SocialArchiveAdjustRecordQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 通过员工ID批量获取社保增减员记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 通过员工ID批量获取社保增减员记录 响应体
/// <para>接口ID：7420038908975382530</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_archive/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_archive_adjust_record%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1SocialArchiveAdjustRecordQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "records": [
            {
                "user_id": "9960875",
                "record_type": "increase",
                "details": [
                    {
                        "description": {
                            "zh_cn": "2024年社保基数调整",
                            "en_us": "2024 Social Insurance Base Adjustment"
                        },
                        "insurance_type": "social_insurance",
                        "insurance_status": "contribution",
                        "id": "null",
                        "tid": "null",
                        "plan_id": "7199837930276308524",
                        "plan_tid": "7199643907243361836",
                        "location_id": "7152398273176192556",
                        "company_id": "7096372135576618540",
                        "account_type": "associated_company",
                        "insurance_account": "ac123456",
                        "base_salary": "1000.10",
                        "insurance_details": [
                            {
                                "insurance_id": "7200725830765790764",
                                "company_deduction": "2000.20",
                                "company_setting": {
                                    "lower_limit": "1000.00",
                                    "upper_limit": "2000.00",
                                    "payment_ratio": "8.00",
                                    "payment_rounding_rule": "rounding",
                                    "payment_decimals": 2,
                                    "fixed_payment": "200.00"
                                },
                                "personal_deduction": "1000.20",
                                "personal_setting": {
                                    "lower_limit": "1000.00",
                                    "upper_limit": "2000.00",
                                    "payment_ratio": "8.00",
                                    "payment_rounding_rule": "round_down",
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1SocialArchiveAdjustRecordQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}