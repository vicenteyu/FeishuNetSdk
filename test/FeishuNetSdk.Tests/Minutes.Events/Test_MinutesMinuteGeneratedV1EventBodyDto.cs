// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_MinutesMinuteGeneratedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 妙记生成 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Minutes.Events;

/// <summary>
/// 测试 妙记生成 事件体
/// <para>接口ID：7644841241633950667</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/events/generated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fevents%2fgenerated</para>
/// </summary>
[TestClass]
public class Test_MinutesMinuteGeneratedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "minutes.minute.generated_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "minute_token": "obcnq3b9jl72l83w4f14xxxx",
        "minute_source": {
            "source_type": "meeting",
            "source_entity_id": "6911188411934433028"
        },
        "subscriber_ids": [
            {
                "union_id": "on_785a8cda5345f665f7187d7d876cb790",
                "user_id": "f3e15a6a",
                "open_id": "ou_2cc0462a0597358575e771bea74e3304"
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Minutes.Events.MinutesMinuteGeneratedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}