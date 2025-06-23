namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 更新会话 请求体
/// <para>接口ID：7358047310868234244</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutAilyV1SessionsByAilySessionIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "channel_context": "{}",
    "metadata": "{}"
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PutAilyV1SessionsByAilySessionIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}