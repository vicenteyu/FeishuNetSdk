// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_PostOAuthV3TokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 user_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 获取 user_access_token 请求体
/// <para>接口ID：7637802672208973014</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/authentication-management/access-token/get-user-access-token-v3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2faccess-token%2fget-user-access-token-v3</para>
/// </summary>
[TestClass]
public class Test_PostOAuthV3TokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "grant_type": "authorization_code",
    "client_id": "cli_a5ca35a685b0x26e",
    "client_secret": "baBqE5um9LbFGDy3X7LcfxQX1sqpXlwy",
    "code": "a61hb967bd094dge949h79bbexd16dfe",
    "redirect_uri": "https://example.com/api/oauth/callback",
    "code_verifier": "TxYmzM4PHLBlqm5NtnCmwxMH8mFlRWl_ipie3O0aVzo"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostOAuthV3TokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}