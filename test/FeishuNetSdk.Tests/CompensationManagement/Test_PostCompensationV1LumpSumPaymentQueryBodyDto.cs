// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="Test_PostCompensationV1LumpSumPaymentQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询一次性支付授予记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 查询一次性支付授予记录 请求体
/// <para>接口ID：7429528484932780060</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1LumpSumPaymentQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ids": [
        "7337149697626801708"
    ],
    "unique_ids": [
        "7337149697626801708"
    ],
    "user_ids": [
        "7337149697626801708"
    ],
    "item_ids": [
        "7337149697626801708"
    ],
    "create_time_gte": "2023-04-01 12:34:56",
    "create_time_lte": "2023-04-01 12:34:56",
    "modify_time_gte": "2023-04-01 12:34:56",
    "modify_time_lte": "2023-04-01 12:34:56",
    "company_ids": [
        "7337149697626801708"
    ],
    "service_company_ids": [
        "7337149697626801708"
    ],
    "department_ids": [
        "7337149697626801708"
    ],
    "job_family_ids": [
        "7337149697626801708"
    ],
    "job_level_ids": [
        "7337149697626801708"
    ],
    "work_location_ids": [
        "7337149697626801708"
    ],
    "employee_type_ids": [
        "7337149697626801708"
    ],
    "onboard_date_gte": "2023-04-01",
    "onboard_date_lte": "2023-04-01",
    "offboard_date_gte": "2023-04-01",
    "offboard_date_lte": "2023-04-01"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1LumpSumPaymentQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}