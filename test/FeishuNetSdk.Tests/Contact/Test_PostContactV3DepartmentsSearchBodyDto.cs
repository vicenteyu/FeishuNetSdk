namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 搜索部门 请求体
/// <para>接口ID：6943913881476841499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostContactV3DepartmentsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "DemoName"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3DepartmentsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}