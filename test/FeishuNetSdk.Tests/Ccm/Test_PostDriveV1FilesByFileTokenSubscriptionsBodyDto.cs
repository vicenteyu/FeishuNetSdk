namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建订阅 请求体
/// <para>接口ID：7065964758428483612</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenSubscriptionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"subscription_type":"comment_update", "file_type":"docx"}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenSubscriptionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}