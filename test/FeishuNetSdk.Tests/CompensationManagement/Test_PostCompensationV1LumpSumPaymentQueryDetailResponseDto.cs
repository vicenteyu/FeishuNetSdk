// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1LumpSumPaymentQueryDetailResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询一次性支付授予明细 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 查询一次性支付授予明细 响应体
/// <para>接口ID：7429528484932796444</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/query_detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fquery_detail</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1LumpSumPaymentQueryDetailResponseDto : TestBase
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
                "id": "7395133551102200876",
                "record_id": "7395133551102168108",
                "user_id": "7337149697626801708",
                "issuance_amount": "2000.00",
                "issuance_status": "to_be_issued",
                "issuance_way": "with_salary",
                "issuance_time": "2024-08-01",
                "currency_id": "6863329932261459464",
                "belong_time": "2025-01-20",
                "create_time": "2024-08-01 12:34:56",
                "modify_time": "2024-08-01 12:34:56",
                "issuance_country_region_id": "6862995757234914824",
                "issuance_pay_group_id": "6862995757234914824"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.PostCompensationV1LumpSumPaymentQueryDetailResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}