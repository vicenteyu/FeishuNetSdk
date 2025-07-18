// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-07-17
//
// Last Modified By : yxr
// Last Modified On : 2025-07-17
// ************************************************************************
// <copyright file="Test_GetPayrollV1CostAllocationDetailsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询成本分摊报表明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 查询成本分摊报表明细 响应体
/// <para>接口ID：7387360801748418561</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/cost_allocation_detail/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fcost_allocation_detail%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1CostAllocationDetailsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "cost_allocation_report_datas": [
            {
                "data_summary_dimensions": [
                    {
                        "dimension_level": 1,
                        "dimension_type": 1,
                        "dimension_value_id": "6823630319749580306",
                        "dimension_names": [
                            {
                                "locale": "zh_cn",
                                "value": "名称"
                            }
                        ],
                        "dimension_titles": [
                            {
                                "locale": "zh_cn",
                                "value": "名称",
                                "id": "723123123123123213"
                            }
                        ]
                    }
                ],
                "compensation_cost_item": {
                    "compensation_costs": [
                        {
                            "compensation_cost_value": "123456.78",
                            "i18n_names": [
                                {
                                    "locale": "zh_cn",
                                    "value": "名称"
                                }
                            ]
                        }
                    ]
                },
                "employment_id": "72321836123692186"
            }
        ],
        "cost_allocation_report_names": [
            {
                "locale": "zh_cn",
                "value": "名称"
            }
        ],
        "pay_period": "2024-06",
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1CostAllocationDetailsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}