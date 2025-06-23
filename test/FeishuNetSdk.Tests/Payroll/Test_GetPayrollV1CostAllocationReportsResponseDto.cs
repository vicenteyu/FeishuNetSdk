namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 查询成本分摊报表汇总数据 响应体
/// <para>接口ID：7319164056023253020</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/cost_allocation_report/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fcost_allocation_report%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1CostAllocationReportsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "pay_period": "2023-11",
        "page_token": "6823630319749580302",
        "has_more": true,
        "cost_allocation_report_names": [
            {
                "locale": "zh_cn",
                "value": "名称"
            }
        ],
        "cost_allocation_report_datas": [
            {
                "data_summary_dimensions": [
                    {
                        "dimension_level": 1,
                        "dimension_type": 1,
                        "dimension_value_id": "6823630319749580306",
                        "enum_dimension": {
                            "enum_value_id": "7188920315914207276",
                            "enum_key": "company"
                        },
                        "dimension_value_lookup_info": {
                            "type": "work_calendar",
                            "id": "6961286846093788621",
                            "code": "D1230011115"
                        },
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
                    "number_of_individuals_for_payment": 100,
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
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1CostAllocationReportsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}