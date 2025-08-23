// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1LumpSumPaymentBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量创建一次性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量创建一次性支付记录 请求体
/// <para>接口ID：7429528484932812828</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1LumpSumPaymentBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": [
        {
            "unique_id": "7402510801304718380_7309316347007764012_7402523725868058156_1726070400000_10000",
            "user_id": "7337149697626801708",
            "total_amount": "2000.00",
            "binding_period": 2,
            "currency_id": "6863329932261459464",
            "issuance_frequency": 3,
            "item_id": "7411039006180312620",
            "reference_period_start_date": "2024-08-01",
            "reference_period_end_date": "2024-08-01",
            "details": [
                {
                    "issuance_amount": "2000.00",
                    "issuance_status": "to_be_issued",
                    "issuance_way": "with_salary",
                    "issuance_time": "2024-08-01",
                    "belong_time": "2025-01-20",
                    "issuance_country_region_id": "6862995757234914824",
                    "issuance_pay_group_id": "6862995757234914824"
                }
            ],
            "remark": "该员工表现优异，为其发放一笔奖金"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1LumpSumPaymentBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}