// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_HireTalentTagSubscriptionV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 人才进展变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire.Events;

/// <summary>
/// 测试 人才进展变更事件 事件体
/// <para>接口ID：7404770953199697922</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/events/tag_subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fevents%2ftag_subscription</para>
/// </summary>
[TestClass]
public class Test_HireTalentTagSubscriptionV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "hire.talent.tag_subscription_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "talent_id": "6890840517010000141",
        "application_id": "6890840517010000141",
        "type": 1,
        "tag": {
            "id": "7023711013443944467",
            "name": {
                "zh_cn": "985",
                "en_us": "985"
            },
            "description": {
                "zh_cn": "985",
                "en_us": "985"
            }
        },
        "lock_status": 1,
        "application_stage": {
            "id": "614218419274131",
            "zh_name": "面试",
            "en_name": "Interview",
            "type": 1
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Hire.Events.HireTalentTagSubscriptionV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}