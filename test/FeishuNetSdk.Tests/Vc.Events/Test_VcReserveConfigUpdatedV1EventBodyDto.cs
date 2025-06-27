// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_VcReserveConfigUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新会议室预定限制 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 更新会议室预定限制 事件体
/// <para>接口ID：7194805625627983875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_VcReserveConfigUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.reserve_config.updated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "scope_id": "omm_3c5dd7e09bac0c1758fcf9511bd1a771",
        "scope_type": 2,
        "approve_config": {
            "approval_switch": 0,
            "approval_condition": 0,
            "meeting_duration": 1,
            "approvers": [
                {
                    "user_id": {
                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                        "user_id": "e33ggbyz",
                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                    }
                }
            ]
        },
        "time_config": {
            "time_switch": 1,
            "days_in_advance": 30,
            "opening_hour": "27900",
            "start_time": "0",
            "end_time": "86400",
            "max_duration": 24
        },
        "reserve_scope_config": {
            "allow_all_users": 1,
            "allow_users": [
                {
                    "user_id": {
                        "union_id": "on_8ed6aa67826108097d9ee143816345",
                        "user_id": "e33ggbyz",
                        "open_id": "ou_84aad35d084aa403a838cf73ee18467"
                    }
                }
            ],
            "allow_depts": [
                {
                    "department_id": "od-47d8b570b0a011e9679a755efcc5f61a"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcReserveConfigUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}