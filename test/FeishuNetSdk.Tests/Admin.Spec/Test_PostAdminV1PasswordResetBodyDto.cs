// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAdminV1PasswordResetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 重置用户的企业邮箱密码 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Admin.Spec;

/// <summary>
/// 测试 重置用户的企业邮箱密码 请求体
/// <para>接口ID：7081092146976161796</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/password/reset</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fpassword%2freset</para>
/// </summary>
[TestClass]
public class Test_PostAdminV1PasswordResetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "password": {
        "ent_email_password": "abcd*efg"
    },
    "user_id": "abc123"
}
""";
        var result = Deserialize<FeishuNetSdk.Admin.Spec.PostAdminV1PasswordResetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}