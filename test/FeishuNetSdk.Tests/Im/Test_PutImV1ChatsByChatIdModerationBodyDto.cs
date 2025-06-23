namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新群发言权限 请求体
/// <para>接口ID：6951292665602899970</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-moderation%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutImV1ChatsByChatIdModerationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "moderation_setting": "moderator_list",
    "moderator_added_list": [
        "4d7a3c6g"
    ],
    "moderator_removed_list": [
        "4d7a3c6g"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PutImV1ChatsByChatIdModerationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}