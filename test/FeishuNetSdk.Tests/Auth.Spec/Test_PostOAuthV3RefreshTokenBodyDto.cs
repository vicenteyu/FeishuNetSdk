// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostOAuthV3RefreshTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 刷新 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 刷新 user_access_token 请求体
/// <para>接口ID：7637802672208956630</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/refresh-user-access-token-v3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2frefresh-user-access-token-v3</para>
/// </summary>
[TestClass]
public class Test_PostOAuthV3RefreshTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "refresh_token",
    "client_id": "cli_a5ca35a685b0x26e",
    "client_secret": "baBqE5um9LbFGDy3X7LcfxQX1sqpXlwy",
    "refresh_token": "eyJhbGciOiJFUzI1NiIs**********XXOYOZz1mfgIYHwM8ZJA"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostOAuthV3RefreshTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}