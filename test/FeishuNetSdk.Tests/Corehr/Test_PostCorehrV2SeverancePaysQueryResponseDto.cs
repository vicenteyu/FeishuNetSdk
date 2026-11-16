// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="Test_PostCorehrV2SeverancePaysQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索被动解除补偿金信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索被动解除补偿金信息 响应体
/// <para>接口ID：7667872540325727194</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2SeverancePaysQueryResponseDto : TestBase
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
                "severance_pay_id": "7660423757252773420",
                "offboarding_id": "7660486572667979308",
                "employment_id": "7659617611689510444",
                "status": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "calculate_status": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "offboarding_date": "2026-08-26",
                "severance_pay_info": {
                    "severance_pay_type": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "standard_severance_pay_amount": "77654.00",
                    "exceeding_severance_pay_amount": "776.00",
                    "currency": "THB",
                    "reason_explanation": "补偿说明",
                    "standard_compensation_start_month": "2026-12-01",
                    "standard_compensation_end_month": "2026-12-01",
                    "standard_compensation_base": "567.00",
                    "standard_compensation_coefficient": "776.00",
                    "actual_standard_amount": "65445.00",
                    "other_compensation_start_month": "2026-12-01",
                    "other_compensation_end_month": "2026-10-01",
                    "other_compensation_base": "7665.00",
                    "other_compensation_coefficient": "8766.00",
                    "other_compensation_amount": "7665.00",
                    "actual_notice_payment_amount": "7665.00",
                    "exceeding_base_start_month": "2026-12-01",
                    "exceeding_base_end_month": "2026-11-01",
                    "exceeding_compensation_base": "7655.00",
                    "exceeding_compensation_coefficient": "7655.00",
                    "actual_excess_amount": "54433.00",
                    "other_floating_base_start_month": "2026-12-01",
                    "other_floating_base_end_month": "2026-12-01",
                    "other_floating_base": "7666.00",
                    "other_floating_coefficient": "1.00",
                    "other_floating_amount": "655.00",
                    "actual_other_floating_amount": "655.00",
                    "expect_severance_pay_amount": "665.00",
                    "severance_pay_amount": "6545.00",
                    "severance_pay_upper_limit": "665545.00",
                    "severance_pay_calculate_explanation": "补偿金信息说明",
                    "standard_compensation_unit": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "other_compensation_unit": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "exceeding_compensation_unit": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    },
                    "other_floating_unit": {
                        "enum_name": "phone_type",
                        "display": [
                            {
                                "lang": "zh-CN",
                                "value": "中文示例"
                            }
                        ]
                    }
                },
                "apply_initiating_time": "1783994400000",
                "process_id": "7660486572667979308",
                "reason": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "reason_explanation": "离职说明",
                "initiator_id": "7249355547343013420",
                "apply_finish_time": "1783994400000",
                "sign_type": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "social_insurance_end_date": "2026-08-01",
                "provident_fund_end_date": "2026-08-01",
                "evaluation_result": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "中文示例"
                        }
                    ]
                },
                "withdrawn_reason": "撤销原因",
                "followers": [
                    "7249355547343013420"
                ],
                "created_time": "1783994400000",
                "updated_time": "1783994400000",
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
                ],
                "signature_file_ids": [
                    "7660423757252773420"
                ],
                "reason_chain": [
                    "voluntary"
                ]
            }
        ],
        "page_token": "page_token_xxx",
        "has_more": true,
        "total": "1"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2SeverancePaysQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}