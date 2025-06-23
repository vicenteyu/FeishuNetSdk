namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 批量查询发薪明细 响应体
/// <para>接口ID：7431973248228638722</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_detail%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1PaymentDetailQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "payment_details": [
            {
                "employee_id": "7202076988667019308",
                "activity_id": "7202076988667019308",
                "payment_accounting_items": [
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.PostPayrollV1PaymentDetailQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}