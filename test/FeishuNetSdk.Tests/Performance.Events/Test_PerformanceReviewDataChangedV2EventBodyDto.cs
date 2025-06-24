// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PerformanceReviewDataChangedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 绩效详情变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance.Events;

/// <summary>
/// 测试 绩效详情变更 事件体
/// <para>接口ID：7351374599659864068</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_data/events/changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_data%2fevents%2fchanged</para>
/// </summary>
[TestClass]
public class Test_PerformanceReviewDataChangedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "performance.review_data.changed_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "items": [
            {
                "user_id": {
                    "union_id": "on_8ed6aa67826108097d9ee143816345",
                    "user_id": "e33ggbyz",
                    "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                },
                "semester_id": "7343576973861453844",
                "activity_id": "7343577163150393363",
                "stage_changes": [
                    {
                        "stage_id": "7026250586485114406",
                        "stage_type": "leader_review",
                        "review_stage_role": "solid_line_leader"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Performance.Events.PerformanceReviewDataChangedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}