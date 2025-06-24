// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHelpdeskV1NotificationsByNotificationIdExecuteSendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 执行推送 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Helpdesk;

/// <summary>
/// 测试 执行推送 请求体
/// <para>接口ID：6999529163292540930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/execute_send</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fexecute_send</para>
/// </summary>
[TestClass]
public class Test_PostHelpdeskV1NotificationsByNotificationIdExecuteSendBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "send_at": "1624326025000"
}
""";
        var result = Deserialize<FeishuNetSdk.Helpdesk.PostHelpdeskV1NotificationsByNotificationIdExecuteSendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}