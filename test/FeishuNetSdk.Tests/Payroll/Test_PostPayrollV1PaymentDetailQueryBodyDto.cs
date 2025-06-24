// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPayrollV1PaymentDetailQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询发薪明细 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 批量查询发薪明细 请求体
/// <para>接口ID：7431973248228638722</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/payment_detail/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fpayment_detail%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPayrollV1PaymentDetailQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "page_index": 100,
    "page_size": 10,
    "acct_item_ids": [
        "7202076988667019333"
    ],
    "employee_ids": [
        "7202076988667019222"
    ],
    "pay_period_start_date": "2024-01-01",
    "pay_period_end_date": "2024-01-31",
    "activity_ids": [
        "7202076988667019308"
    ],
    "include_segment_data": false
}
""";
        var result = Deserialize<FeishuNetSdk.Payroll.PostPayrollV1PaymentDetailQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}