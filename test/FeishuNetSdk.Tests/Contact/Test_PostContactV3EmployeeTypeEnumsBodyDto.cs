// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostContactV3EmployeeTypeEnumsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增人员类型 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 新增人员类型 请求体
/// <para>接口ID：6985055606752575516</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostContactV3EmployeeTypeEnumsBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Contact.PostContactV3EmployeeTypeEnumsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}