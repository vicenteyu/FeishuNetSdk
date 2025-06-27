// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAuthV3TenantAccessTokenInternalBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 自建应用获取 tenant_access_token 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 自建应用获取 tenant_access_token 请求体
/// <para>接口ID：6995779366223724548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/tenant_access_token_internal</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNz4SO0MjL5QzM%2fauth-v3%2fauth%2ftenant_access_token_internal</para>
/// </summary>
[TestClass]
public class Test_PostAuthV3TenantAccessTokenInternalBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_id": "cli_slkdjalasdkjasd",
    "app_secret": "dskLLdkasdjlasdKK"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostAuthV3TenantAccessTokenInternalBodyDto>(json);
        Assert.IsNotNull(result);
    }
}