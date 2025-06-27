// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrJobChangeStatusUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 异动状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 异动状态变更 事件体
/// <para>接口ID：7407271999612436508</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/job-change-events/status_updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fevents%2fstatus_updated</para>
/// </summary>
[TestClass]
public class Test_CorehrJobChangeStatusUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.job_change.status_updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "employment_id": "7072306364927985196",
        "target_user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "job_change_id": "7044427347159746085",
        "transfer_mode": 1,
        "transfer_type_unique_identifier": "internal_transfer",
        "transfer_reason_unique_identifier": "internal_transfer",
        "process_id": "7090409013925398060",
        "effective_date": "2022-04-03",
        "status": 1,
        "transfer_key": "transfer_3627531"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrJobChangeStatusUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}