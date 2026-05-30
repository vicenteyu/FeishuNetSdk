// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_PostVcV1MeetingsSubscriptionBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 订阅会议变更事件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 订阅会议变更事件 请求体
/// <para>接口ID：7644841241633967051</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fsubscription</para>
/// </summary>
[TestClass]
public class Test_PostVcV1MeetingsSubscriptionBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "event_type": "vc.meeting.participant_meeting_ended_v1"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1MeetingsSubscriptionBodyDto>(json);
        Assert.IsNotNull(result);
    }
}