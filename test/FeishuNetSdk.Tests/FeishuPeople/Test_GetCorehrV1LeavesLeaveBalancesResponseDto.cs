// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV1LeavesLeaveBalancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量查询员工假期余额 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询员工假期余额 响应体
/// <para>接口ID：7126729166647869443</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_balances</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_balances</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1LeavesLeaveBalancesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employment_leave_balance_list": [
            {
                "employment_id": "4718803945687580505",
                "employment_name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "as_of_date": "2022-07-29",
                "leave_balance_list": [
                    {
                        "leave_type_id": "4718803945687580505",
                        "leave_type_name": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ],
                        "historical_cycles_left": "0",
                        "this_cycle_total": "0",
                        "this_cycle_taken": "0",
                        "leave_balance": "0",
                        "leave_duration_unit": 1,
                        "history_cycle_accrual": "0",
                        "balance_in_current_cycle": "0",
                        "taken": "0",
                        "taken_history_cycle": "0",
                        "offboarding_balance": "0",
                        "taken_current_date": "0",
                        "offboarding_granted": "0"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "{\"eu_nc\":\"[\\\"6994333322503669260\\\"]\"}"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1LeavesLeaveBalancesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}