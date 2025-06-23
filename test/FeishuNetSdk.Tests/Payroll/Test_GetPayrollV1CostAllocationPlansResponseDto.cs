namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 批量查询成本分摊方案 响应体
/// <para>接口ID：7319164056023269404</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/cost_allocation_plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fcost_allocation_plan%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1CostAllocationPlansResponseDto : TestBase
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
                "id": "6823630319749593096",
                "names": [
                    {
                        "locale": "zh_cn",
                        "value": "名称"
                    }
                ],
                "applicable_country_region": "6823630319749593389",
                "dimensions": [
                    {
                        "i18n_names": [
                            {
                                "locale": "zh_cn",
                                "value": "名称",
                                "id": "723123123123123213"
                            }
                        ],
                        "api_name": "company",
                        "obj_api_name": "jobData"
                    }
                ],
                "cost_items": [
                    {
                        "id": "7433424967234601004",
                        "name": [
                            {
                                "locale": "zh_cn",
                                "value": "名称",
                                "id": "723123123123123213"
                            }
                        ],
                        "enable_correct": true
                    }
                ]
            }
        ],
        "page_token": "6823630319749592467",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1CostAllocationPlansResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}