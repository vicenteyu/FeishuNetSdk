namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 创建单位 响应体
/// <para>接口ID：7023995901275242499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UnitResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "unit_id": "BU121"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PostContactV3UnitResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}