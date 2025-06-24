// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_AcsAccessRecordCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增门禁访问记录 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs.Events;

/// <summary>
/// 测试 新增门禁访问记录 事件体
/// <para>接口ID：6979790924692013058</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/access_record/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2faccess_record%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_AcsAccessRecordCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "acs.access_record.created_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "access_record_id": "6939433228970082591",
        "user_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "device_id": "6939433228970082593",
        "is_clock_in": true,
        "is_door_open": true,
        "access_time": "1624520221"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Acs.Events.AcsAccessRecordCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}