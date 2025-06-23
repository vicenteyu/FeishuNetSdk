namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 查询发薪活动明细列表 响应体
/// <para>接口ID：7411460155089502211</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_detail/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity_detail%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1PaymentActivityDetailsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "payment_activity_details": [
            {
                "employee_id": "7202076988667019308",
                "payment_details": [
                    {
                        "id": "7202076988667019308",
                        "accounting_item_names": [
                            {
                                "locale": "zh_cn",
                                "value": "名称"
                            }
                        ],
                        "accounting_item_value": {
                            "original_value": "100",
                            "reference_values": [
                                {
                                    "locale": "zh_cn",
                                    "value": "名称"
                                }
                            ]
                        },
                        "segment_values": [
                            {
                                "start_time": "7220356259681386540",
                                "end_time": "7220356259681386540",
                                "reference_values": [
                                    {
                                        "locale": "zh_cn",
                                        "value": "名称"
                                    }
                                ],
                                "original_value": "10000"
                            }
                        ],
                        "accounting_item_type": 1
                    }
                ]
            }
        ],
        "total": 50000
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1PaymentActivityDetailsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}