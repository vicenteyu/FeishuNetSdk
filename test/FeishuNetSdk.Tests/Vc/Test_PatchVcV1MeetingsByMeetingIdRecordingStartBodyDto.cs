namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 开始录制 请求体
/// <para>接口ID：6960861158593150980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/meeting-recording/start</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting-recording%2fstart</para>
/// </summary>
[TestClass]
public class Test_PatchVcV1MeetingsByMeetingIdRecordingStartBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "timezone": 8
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PatchVcV1MeetingsByMeetingIdRecordingStartBodyDto>(json);
        Assert.IsNotNull(result);
    }
}