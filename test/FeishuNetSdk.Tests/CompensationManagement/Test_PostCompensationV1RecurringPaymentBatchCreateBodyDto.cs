// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="Test_PostCompensationV1RecurringPaymentBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量创建经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量创建经常性支付记录 请求体
/// <para>接口ID：7441804833880211460</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1RecurringPaymentBatchCreateBodyDto : TestBase
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
            "item_id": "7411039006180312620",
            "each_amount": "20.00",
            "start_date": "2024-08-01",
            "end_date": "2025-08-01",
            "currency_id": "6863329932261459464",
            "issuance_type": "with_salary",
            "issuance_period": "year",
            "remark": "这是个备注",
            "issuance_country_region_id": "6862995745046267400"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1RecurringPaymentBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}