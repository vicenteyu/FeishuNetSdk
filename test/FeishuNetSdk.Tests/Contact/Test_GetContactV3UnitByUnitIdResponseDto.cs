namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取单位信息 响应体
/// <para>接口ID：7023995901275291651</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fget</para>
/// </summary>
[TestClass]
public class Test_GetContactV3UnitByUnitIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "unit": {
            "unit_id": "BU121",
            "name": "消费者事业部",
            "unit_type": "事业部"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3UnitByUnitIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}