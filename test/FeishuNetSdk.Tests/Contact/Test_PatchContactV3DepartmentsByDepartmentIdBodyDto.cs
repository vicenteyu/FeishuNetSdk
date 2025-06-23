namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 修改部门部分信息 请求体
/// <para>接口ID：6943913881476923419</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3DepartmentsByDepartmentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "DemoName",
    "i18n_name": {
        "zh_cn": "Demo名称",
        "ja_jp": "デモ名",
        "en_us": "Demo Name"
    },
    "parent_department_id": "D067",
    "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "order": "100",
    "create_group_chat": false,
    "leaders": [
        {
            "leaderType": 1,
            "leaderID": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
        }
    ],
    "group_chat_employee_types": [
        1
    ],
    "department_hrbps": [
        "ou_7dab8a3d3cdcc9da365777c7ad535d62"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3DepartmentsByDepartmentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}