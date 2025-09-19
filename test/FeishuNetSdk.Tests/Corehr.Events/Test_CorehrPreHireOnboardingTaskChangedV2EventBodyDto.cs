// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="Test_CorehrPreHireOnboardingTaskChangedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 入职流程状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 入职流程状态变更 事件体
/// <para>接口ID：7394722460207382556</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/pre_hire/pre-hire-events/onboarding_task_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fevents%2fonboarding_task_changed</para>
/// </summary>
[TestClass]
public class Test_CorehrPreHireOnboardingTaskChangedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.pre_hire.onboarding_task_changed_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "tenant_id": "6685321562717324807",
        "pre_hire_id": "7225204420787144236",
        "onboarding_task_changes": [
            {
                "after_status": "in_progress",
                "task_code": "2"
            }
        ],
        "onboarding_flow_change": {
            "after_status": "in_progress"
        },
        "onboarding_flow_id": "65c245b7859c6e77d2290e00",
        "flow_info": {
            "id": "628caefb0eb4ac9c806982ee",
            "name": {
                "zh_cn": "王冰",
                "en_us": "Bob"
            }
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrPreHireOnboardingTaskChangedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}