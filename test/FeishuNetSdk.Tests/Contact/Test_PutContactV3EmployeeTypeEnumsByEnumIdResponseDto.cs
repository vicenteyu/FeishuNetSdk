// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutContactV3EmployeeTypeEnumsByEnumIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新人员类型 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新人员类型 响应体
/// <para>接口ID：6985055606752460828</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/employee_type_enum/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2femployee_type_enum%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutContactV3EmployeeTypeEnumsByEnumIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employee_type_enum": {
            "enum_id": "exGeIjow7zIqWMy+ONkFxA==",
            "enum_value": "2",
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PutContactV3EmployeeTypeEnumsByEnumIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}