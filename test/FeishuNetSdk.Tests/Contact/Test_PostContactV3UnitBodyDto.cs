namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 创建单位 请求体
/// <para>接口ID：7023995901275242499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UnitBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "unit_id": "BU121",
    "name": "消费者事业部",
    "unit_type": "子公司"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3UnitBodyDto>(json);
        Assert.IsNotNull(result);
    }
}