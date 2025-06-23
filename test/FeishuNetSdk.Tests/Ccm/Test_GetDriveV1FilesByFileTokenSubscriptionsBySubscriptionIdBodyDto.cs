namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取订阅状态 请求体
/// <para>接口ID：7065964758428516380</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{"file_type":"docx"}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.GetDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}