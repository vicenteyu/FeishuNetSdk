// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV3UnitUnbindDepartmentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 解除部门与单位的绑定关系 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 解除部门与单位的绑定关系 请求体
/// <para>接口ID：7023995901275340803</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/unbind_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2funbind_department</para>
/// </summary>
[TestClass]
public class Test_PostContactV3UnitUnbindDepartmentBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "unit_id": "BU121",
    "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
    "department_id_type": "open_department_id"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3UnitUnbindDepartmentBodyDto>(json);
        Assert.IsNotNull(result);
    }
}