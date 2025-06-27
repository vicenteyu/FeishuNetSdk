// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV3DepartmentsUnbindDepartmentChatBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 部门群转为普通群 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 部门群转为普通群 请求体
/// <para>接口ID：7069758645957836801</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/unbind_department_chat</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2funbind_department_chat</para>
/// </summary>
[TestClass]
public class Test_PostContactV3DepartmentsUnbindDepartmentChatBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_id": "D096"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3DepartmentsUnbindDepartmentChatBodyDto>(json);
        Assert.IsNotNull(result);
    }
}