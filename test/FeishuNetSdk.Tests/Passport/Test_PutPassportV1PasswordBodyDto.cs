// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-31
//
// Last Modified By : yxr
// Last Modified On : 2026-07-31
// ************************************************************************
// <copyright file="Test_PutPassportV1PasswordBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 重置登录密码 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Passport;

/// <summary>
/// 测试 重置登录密码 请求体
/// <para>接口ID：7537665430859382787</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/passport-v1/password/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fpassword%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutPassportV1PasswordBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "abcd1234ou_7dab8a3d3cdcc9da365777c7ad535d62",
    "password": "1234abcd",
    "require_reset": false
}
""";
        var result = Deserialize<FeishuNetSdk.Passport.PutPassportV1PasswordBodyDto>(json);
        Assert.IsNotNull(result);
    }
}