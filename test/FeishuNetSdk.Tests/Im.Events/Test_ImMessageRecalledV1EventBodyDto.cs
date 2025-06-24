// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_ImMessageRecalledV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤回消息 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Events;

/// <summary>
/// 测试 撤回消息 事件体
/// <para>接口ID：7145387488308363267</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/events/recalled</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fevents%2frecalled</para>
/// </summary>
[TestClass]
public class Test_ImMessageRecalledV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "im.message.recalled_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "message_id": "om_dc13264520392913993dd051dba21dcf",
        "chat_id": "oc_5ad11d72b830411d72b836c20",
        "recall_time": "1615380573411",
        "recall_type": "message_owner"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Im.Events.ImMessageRecalledV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}