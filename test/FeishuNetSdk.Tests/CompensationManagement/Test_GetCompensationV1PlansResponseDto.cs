namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量查询薪资方案 响应体
/// <para>接口ID：7314129756769812484</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fplan%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1PlansResponseDto : TestBase
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
                "id": "2134193289",
                "tid": "129738122",
                "name": "基本月薪方案",
                "description": "基本月薪方案描述",
                "effective_date": "2022-10-20",
                "plan_scope": {
                    "is_all": false,
                    "plan_conditions": [
                        {
                            "left_type": 7,
                            "operator": 1,
                            "right_value": [
                                "413431223"
                            ]
                        }
                    ]
                },
                "currency_id": "341324121",
                "probation_salary_status": true,
                "plan_items": [
                    {
                        "adjustment_type": "manual",
                        "item_id": "21341234",
                        "plan_item_logic": {
                            "fixed": "60",
                            "formula": {
                                "expr": "${0} +${1}",
                                "formula_params": [
                                    {
                                        "ref_type": 1,
                                        "id": "23143242"
                                    }
                                ]
                            }
                        },
                        "probation_discount_type": "percentum",
                        "probation_discount_percentum": "80.00"
                    }
                ],
                "plan_indicators": [
                    {
                        "indicator_id": "13243432",
                        "plan_indicator_logic": {
                            "fixed": "60",
                            "formula": {
                                "expr": "${0} +${1}",
                                "formula_params": [
                                    {
                                        "ref_type": 1,
                                        "id": "23143242"
                                    }
                                ]
                            }
                        }
                    }
                ],
                "i18n_names": [
                    {
                        "locale": "zh_cn",
                        "value": "中文名称"
                    }
                ],
                "i18n_descriptions": [
                    {
                        "locale": "zh_cn",
                        "value": "中文名称"
                    }
                ]
            }
        ],
        "page_token": "123412344",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1PlansResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}