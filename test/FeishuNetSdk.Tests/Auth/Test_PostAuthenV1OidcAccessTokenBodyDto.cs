// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAuthenV1OidcAccessTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth;

/// <summary>
/// 测试 获取 user_access_token 请求体
/// <para>接口ID：7277403063290724380</para>
/// <para>文档地址：https://open.feishu.cn/document/historic-version/authen/create-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2foidc-access_token%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAuthenV1OidcAccessTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "authorization_code",
    "code": "xMSldislSkdK"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.PostAuthenV1OidcAccessTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}