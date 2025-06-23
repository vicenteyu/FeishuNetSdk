namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 指定群管理员 请求体
/// <para>接口ID：6995085510524698625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/add_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fadd_managers</para>
/// </summary>
[TestClass]
public class Test_PostImV1ChatsByChatIdManagersAddManagersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "manager_ids": [
        "ou_9204a37300b3700d61effaa439f34295"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV1ChatsByChatIdManagersAddManagersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}