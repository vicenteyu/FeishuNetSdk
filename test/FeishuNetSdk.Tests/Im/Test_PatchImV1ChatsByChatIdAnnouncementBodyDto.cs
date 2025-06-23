namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新群公告信息 请求体
/// <para>接口ID：6946222931479511041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-announcement/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-announcement%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchImV1ChatsByChatIdAnnouncementBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "revision": "12",
    "requests": [
        "{\"requestType\":\"InsertBlocksRequestType\",\"insertBlocksRequest\":{\"payload\":\"{\\\"blocks\\\":[{\\\"type\\\":\\\"paragraph\\\",\\\"paragraph\\\":{\\\"elements\\\":[{\\\"type\\\":\\\"textRun\\\",\\\"textRun\\\":{\\\"text\\\":\\\"Docs API Sample Content\\\",\\\"style\\\":{}}}],\\\"style\\\":{}}}]}\",\"location\":{\"zoneId\":\"0\",\"index\":0, \"endOfZone\": true}}}"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PatchImV1ChatsByChatIdAnnouncementBodyDto>(json);
        Assert.IsNotNull(result);
    }
}