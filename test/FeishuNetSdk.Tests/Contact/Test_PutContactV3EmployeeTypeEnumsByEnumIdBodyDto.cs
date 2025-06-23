namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新人员类型 请求体
/// <para>接口ID：6985055606752460828</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutContactV3EmployeeTypeEnumsByEnumIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": "专家",
    "enum_type": 2,
    "enum_status": 1,
    "i18n_content": [
        {
            "locale": "zh_cn",
            "value": "专家（中文）"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PutContactV3EmployeeTypeEnumsByEnumIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}