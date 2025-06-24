namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取周期任务（指定用户） 响应体
/// <para>接口ID：7275704938197221378</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/stage_task/find_by_user_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fstage_task%2ffind_by_user_list</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV1StageTasksFindByUserListResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "base": {
            "end_time": "1748707140000",
            "semester_id": "7235911950407352321",
            "semester_name": {
                "en-US": "Demo Semester",
                "zh-CN": "示例周期"
            },
            "start_time": "1684684800000"
        },
        "items": [
            {
                "stage_num_lists": [
                    {
                        "task_option_id": 1,
                        "stage_num": 1
                    },
                    {
                        "task_option_id": 2,
                        "stage_num": 1
                    },
                    {
                        "task_option_id": 3,
                        "stage_num": 0
                    }
                ],
                "stage_task_info_lists": [
                    {
                        "deadline": "1717142244000",
                        "jump_url": "https://performance.feishu-pre.cn/perf/review/7235911950407352321/7235906557915987996/members",
                        "name": {
                            "en-US": "confirm_invitation",
                            "zh-CN": "360° 确认"
                        },
                        "need_todo_count": 10,
                        "stage_id": "7270346432875692033",
                        "stage_task_status": "need_todo",
                        "task_option_id": 1
                    },
                    {
                        "deadline": "1717142244000",
                        "jump_url": "https://performance.feishu-pre.cn/perf/review/7235911950407352321/7235906557916086300",
                        "name": {
                            "en-US": "pdt_manager_review",
                            "zh-CN": "pdt项目经理上级评估"
                        },
                        "need_todo_count": 2,
                        "stage_id": "7270346432875741185",
                        "stage_task_status": "all_done",
                        "task_option_id": 2
                    }
                ],
                "user_id": "bega29ca"
            }
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Performance.PostPerformanceV1StageTasksFindByUserListResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}