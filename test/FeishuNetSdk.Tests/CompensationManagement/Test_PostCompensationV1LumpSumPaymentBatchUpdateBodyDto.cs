// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1LumpSumPaymentBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量更正一次性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量更正一次性支付记录 请求体
/// <para>接口ID：7430824932635181060</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1LumpSumPaymentBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "records": [
        {
            "id": "7397033607132351532",
            "total_amount": "2000.00",
            "binding_period": 2,
            "currency_id": "6863329932261459464",
            "issuance_frequency": 3,
            "remark": "该员工奖金数据不正确，予以更正",
            "reference_period_start_date": "2024-08-01",
            "reference_period_end_date": "2024-08-01",
            "details": [
                {
                    "id": "7395133551102200876",
                    "issuance_amount": "2000.00",
                    "issuance_status": "to_be_issued",
                    "issuance_way": "with_salary",
                    "issuance_time": "2024-08-20",
                    "belong_time": "2025-01-20",
                    "issuance_country_region_id": "6862995757234914824",
                    "issuance_pay_group_id": "6862995757234914824"
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1LumpSumPaymentBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}