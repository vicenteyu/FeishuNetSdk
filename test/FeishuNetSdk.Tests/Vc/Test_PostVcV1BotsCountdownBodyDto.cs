// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-09-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_PostVcV1BotsCountdownBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 会中倒计时 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 会中倒计时 请求体
/// <para>接口ID：7680486345160821966</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/countdown</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fcountdown</para>
/// </summary>
[TestClass]
public class Test_PostVcV1BotsCountdownBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "meeting_id": "7628568141510692381",
    "action": "set",
    "duration": "10",
    "need_play_audio_at_end": false,
    "reminder_before_end": "1"
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1BotsCountdownBodyDto>(json);
        Assert.IsNotNull(result);
    }
}