// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1SocialPlansQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据方案ID和生效日期批量查询参保方案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 根据方案ID和生效日期批量查询参保方案 响应体
/// <para>接口ID：7420038908975431682</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/social_plan/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fsocial_plan%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1SocialPlansQueryResponseDto : TestBase
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
                "plan_id": "7198138281677325868",
                "plan_tid": "7198138281677358636",
                "name": {
                    "zh_cn": "sky-公积金参保方案",
                    "en_us": "sky-provident fund plan test"
                },
                "effective_date": "2024-01-01",
                "active": false,
                "insurance_type": "provident_fund",
                "scope": {
                    "is_all": true,
                    "rules": [
                        [
                            {
                                "left_type": 1,
                                "operator": 1,
                                "right_values": [
                                    "1"
                                ]
                            }
                        ]
                    ]
                },
                "item_detail": [
                    {
                        "item_id": "7200726176044680748",
                        "item_name": {
                            "zh_cn": "养老保险",
                            "en_us": "endowment insurance"
                        },
                        "item_setting_of_person": {
                            "lower_limit": "1000.00",
                            "upper_limit": "2000.00",
                            "payment_ratio": "8.00",
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
                        "payment_frequency": "quarterly",
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
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1SocialPlansQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}