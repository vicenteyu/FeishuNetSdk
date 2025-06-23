namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 离职员工 请求体
/// <para>接口ID：7359428154233602052</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteDirectoryV1EmployeesByEmployeeIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "options": {
        "resigned_employee_resource_receiver": {
            "department_chat_acceptor_employee_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
            "external_chat_acceptor_employee_id": "eehsdna",
            "docs_acceptor_employee_id": "eehsdna",
            "calendar_acceptor_employee_id": "eehsdna",
            "application_acceptor_employee_id": "eehsdna",
            "helpdesk_acceptor_employee_id": "eehsdna",
            "approval_acceptor_employee_id": "eehsdna",
            "email_acceptor_employee_id": "eehsdna",
            "minutes_acceptor_employee_id": "eehsdna",
            "survey_acceptor_employee_id": "eehsdna",
            "anycross_acceptor_employee_id": "eehsdna"
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.DeleteDirectoryV1EmployeesByEmployeeIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}