// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="Test_PostCompensationV1RecurringPaymentQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 查询经常性支付记录 请求体
/// <para>接口ID：7441804833880227844</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1RecurringPaymentQueryBodyDto : TestBase
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
    "start_date_gte": "2023-04-01",
    "start_date_lte": "2023-04-01",
    "end_date_gte": "2025-04-01",
    "end_date_lte": "2025-08-01",
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
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1RecurringPaymentQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}