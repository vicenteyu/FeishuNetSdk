namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新群置顶 请求体
/// <para>接口ID：7043611687799816193</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/put_top_notice</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-top_notice%2fput_top_notice</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdTopNoticePutTopNoticeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "chat_top_notice": [
        {
            "action_type": "2",
            "message_id": "om_dc13264520392913993dd051dba21dcf"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsByChatIdTopNoticePutTopNoticeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}