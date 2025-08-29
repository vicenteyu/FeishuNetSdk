// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="Test_PostCompensationV1RecurringPaymentBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量更正经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量更正经常性支付记录 请求体
/// <para>接口ID：7441804833880244228</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1RecurringPaymentBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": [
        {
            "id": "7397033607132351532",
            "each_amount": "10.00",
            "start_date": "2024-10-20",
            "end_date": "2025-03-20",
            "currency_id": "6863329932261459464",
            "issuance_type": "with_salary",
            "remark": "这是个备注",
            "issuance_country_region_id": "6862995745046267400"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1RecurringPaymentBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}