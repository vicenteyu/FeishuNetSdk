// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_GetCompensationV1SocialPlansResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据生效日期分页查询参保方案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 根据生效日期分页查询参保方案 响应体
/// <para>接口ID：7420038908975448066</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_plan%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1SocialPlansResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "plans": [
            {
                "plan_id": "7198027289165088300",
                "plan_tid": "7198027289165055532",
                "name": {
                    "zh_cn": "2024年度社保方案",
                    "en_us": "2024 Social Insurance Plan"
                },
                "effective_date": "2024-01-01",
                "active": true,
                "insurance_type": "social_insurance",
                "scope": {
                    "is_all": true,
                    "rules": [
                        [
                            {
                                "left_type": 1,
                                "operator": 1,
                                "right_values": [
                                    "7283712673258931756"
                                ]
                            }
                        ]
                    ]
                },
                "item_detail": [
                    {
                        "item_id": "7200725830765987372",
                        "item_name": {
                            "zh_cn": "医疗保险",
                            "en_us": "medical insurance"
                        },
                        "item_setting_of_person": {
                            "lower_limit": "1000.00",
                            "upper_limit": "2000.00",
                            "payment_ratio": "9.0",
                            "payment_rounding_rule": "rounding",
                            "payment_decimals": 2,
                            "fixed_payment": "200.00"
                        },
                        "item_setting_of_company": {
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
                "remark": {
                    "zh_cn": "中文备注",
                    "en_us": "english remark"
                }
            }
        ],
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1SocialPlansResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}