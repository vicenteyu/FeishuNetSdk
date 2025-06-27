// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ApplicationApplicationCreatedV6EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 应用创建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application.Events;

/// <summary>
/// 测试 应用创建 事件体
/// <para>接口ID：7050360820601405468</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/event/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_ApplicationApplicationCreatedV6EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "application.application.created_v6",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "app_id": "cli_9f5343c580712544",
        "name": "应用名称",
        "description": "应用描述",
        "avatar": "https://s1-imfile.feishucdn.com/static-resource/v1/c1f2f629-65e5-462c-be6a-bf327f971edg",
        "app_scene_type": 0,
        "primary_language": "zh_cn",
        "create_source": "developer_console"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Application.Events.ApplicationApplicationCreatedV6EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}