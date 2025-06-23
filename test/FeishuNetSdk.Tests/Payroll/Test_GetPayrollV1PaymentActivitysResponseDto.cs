namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 查询发薪活动列表 响应体
/// <para>接口ID：7411460155089518595</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_activity/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_activity%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1PaymentActivitysResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "payment_activitys": [
            {
                "activity_id": "7202076988667019308",
                "activity_names": [
                    {
                        "locale": "zh_cn",
                        "value": "名称"
                    }
                ],
                "pay_date": "2020-10-31",
                "total_number_of_payroll": 100,
                "number_of_calculation_activities": 1000,
                "calculation_activities": [
                    {
                        "calculation_activity_id": "7371828319837012009",
                        "calculation_activity_names": [
                            {
                                "locale": "zh_cn",
                                "value": "名称"
                            }
                        ]
                    }
                ],
                "activity_status": 400
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1PaymentActivitysResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}