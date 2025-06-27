// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_CorehrLocationUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新地点 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr.Events;

/// <summary>
/// 测试 更新地点 事件体
/// <para>接口ID：7423693709785923587</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_CorehrLocationUpdatedV2EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "corehr.location.updated_v2",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "location_id": "201571101",
        "field_changes": [
            "address"
        ],
        "sub_events": [
            {
                "id": "7818231238918192",
                "entity": "address",
                "agg_entity": "company",
                "agg_entity_id": "7291273149417948716",
                "agg_entity_field": "registered_office_address",
                "opt_type": 2,
                "field_changes": [
                    "active"
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Corehr.Events.CorehrLocationUpdatedV2EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}