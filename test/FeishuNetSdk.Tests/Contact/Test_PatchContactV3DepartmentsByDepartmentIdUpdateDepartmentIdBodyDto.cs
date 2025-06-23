namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新部门 ID 请求体
/// <para>接口ID：7257363132833546242</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/department/update_department_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate_department_id</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3DepartmentsByDepartmentIdUpdateDepartmentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "new_department_id": "NewDevDepartID"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3DepartmentsByDepartmentIdUpdateDepartmentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}