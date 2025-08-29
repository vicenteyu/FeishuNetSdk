// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="Test_PostCompensationV1RecurringPaymentQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询经常性支付记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 查询经常性支付记录 响应体
/// <para>接口ID：7441804833880227844</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1RecurringPaymentQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "records": [
            {
                "id": "7397033607132351532",
                "unique_id": "7402510801304718380_7309316347007764012_7402523725868058156_1726070400000_10000",
                "user_id": "7337149697626801708",
                "item_id": "7411039006180312620",
                "issuance_type": "with_salary",
                "each_amount": "24.00",
                "start_date": "2024-01-10",
                "end_date": "2025-01-20",
                "issuance_period": "year",
                "currency_id": "6863329932261459464",
                "remark": "这是个备注",
                "issuance_country_region_id": "6862995745046267400"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1RecurringPaymentQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}