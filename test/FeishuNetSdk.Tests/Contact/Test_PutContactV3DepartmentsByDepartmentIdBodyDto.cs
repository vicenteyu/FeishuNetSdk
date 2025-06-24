// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutContactV3DepartmentsByDepartmentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新部门所有信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新部门所有信息 请求体
/// <para>接口ID：6943913881477021723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutContactV3DepartmentsByDepartmentIdBodyDto : TestBase
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
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PutContactV3DepartmentsByDepartmentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}