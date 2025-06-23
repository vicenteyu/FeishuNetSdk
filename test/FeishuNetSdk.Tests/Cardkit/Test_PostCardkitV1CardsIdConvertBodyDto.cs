namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 转换 ID 请求体
/// <para>接口ID：7397265677100957699</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/id_convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fid_convert</para>
/// </summary>
[TestClass]
public class Test_PostCardkitV1CardsIdConvertBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "message_id": "om_fbdf6ed2e17f1d98e78fb26c1370186e"
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PostCardkitV1CardsIdConvertBodyDto>(json);
        Assert.IsNotNull(result);
    }
}