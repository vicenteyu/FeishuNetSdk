// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-01
// ************************************************************************
// <copyright file="Test_AuthUserAccessTokenRevokedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 撤销用户授权事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth.Events;

/// <summary>
/// 测试 撤销用户授权事件 事件体
/// <para>接口ID：7384406199519510532</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/auth-v4/revoked</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2fauth-v4%2fuser_access_token%2fevents%2frevoked</para>
/// </summary>
[TestClass]
public class Test_AuthUserAccessTokenRevokedV4EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "auth.user_access_token.revoked_v4",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "revoke_token_type": "user_access_token refresh_token",
        "revoke_reason": "Revoked by security and risk control action.",
        "open_id": "ou_c99c5f35d542efc7ee492afe11af19ef",
        "union_id": "on_cad4860e7af114fb4ff6c5d496d1dd76",
        "user_id": "gg895344"
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Auth.Events.AuthUserAccessTokenRevokedV4EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}