// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHumanAuthenticationV1IdentitiesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 录入身份信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.HumanAuthentication;

/// <summary>
/// 测试 录入身份信息 响应体
/// <para>接口ID：6940461543747305500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fidentity%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHumanAuthenticationV1IdentitiesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "verify_uid": "ou_2eb5483cb377daa5054bc6f86e2089a5"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.HumanAuthentication.PostHumanAuthenticationV1IdentitiesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}