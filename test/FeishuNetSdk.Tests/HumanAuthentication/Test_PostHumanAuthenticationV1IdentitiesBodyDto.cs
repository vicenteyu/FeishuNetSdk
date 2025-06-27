// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHumanAuthenticationV1IdentitiesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 录入身份信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.HumanAuthentication;

/// <summary>
/// 测试 录入身份信息 请求体
/// <para>接口ID：6940461543747305500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fidentity%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHumanAuthenticationV1IdentitiesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "identity_name": "张三",
    "identity_code": "4xxxxxxxx",
    "mobile": "13xxxxxxx"
}
""";
        var result = Deserialize<FeishuNetSdk.HumanAuthentication.PostHumanAuthenticationV1IdentitiesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}