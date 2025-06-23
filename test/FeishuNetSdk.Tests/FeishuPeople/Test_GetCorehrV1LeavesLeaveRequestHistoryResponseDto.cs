namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 批量查询员工请假记录 响应体
/// <para>接口ID：7126729166647902211</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/leave/leave_request_history</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fleave%2fleave_request_history</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1LeavesLeaveRequestHistoryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "leave_request_list": [
            {
                "leave_request_id": "4718803945687580505",
                "employment_id": "4718803945687580505",
                "employment_name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "leave_type_id": "0",
                "leave_type_name": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "start_time": "2022-07-06",
                "end_time": "2023-01-05",
                "leave_duration": "2",
                "leave_duration_unit": 2,
                "leave_request_status": 2,
                "grant_source": "manual",
                "return_time": "1662134400",
                "submitted_at": "1659080476",
                "submitted_by": "7109664941775241244",
                "notes": "备注",
                "approval_date": "2022-09-09",
                "is_deducted": false,
                "details": [
                    {
                        "leave_request_id": "4718803945687580505",
                        "leave_date": "2022-07-07",
                        "leave_duration": "1",
                        "leave_duration_unit": 1,
                        "paid_type": 1
                    }
                ],
                "leave_type_code": "Annual Leave",
                "actual_end_date": "2022-08-02",
                "estimated_end_date": "2022-08-02",
                "time_zone": "Asia/Shanghai",
                "data_source": 1,
                "leave_process_id": [
                    "7304865941202929196"
                ],
                "leave_correct_process_id": [
                    "7304865941202929196"
                ],
                "leave_cancel_process_id": [
                    "7304865941202929196"
                ],
                "leave_return_process_id": [
                    "7304865941202929196"
                ],
                "wd_paid_type": 1,
                "leave_correct_process_info": [
                    {
                        "process_id": "4718803945687580505",
                        "process_status": "passed",
                        "process_apply_time": "2024-01-01 00:00:00"
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "[1712932008000,\"7356863257632491046\"]"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1LeavesLeaveRequestHistoryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}