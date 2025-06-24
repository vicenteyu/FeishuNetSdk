// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostMinaV2TokenLoginValidateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 user_access_token（小程序） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 获取 user_access_token（小程序） 响应体
/// <para>接口ID：6907569745298817026</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/gadget/-web-app-api/open-ability/login/code2session</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuYjL24iN%2fukjM04SOyQjL5IDN</para>
/// </summary>
[TestClass]
public class Test_PostMinaV2TokenLoginValidateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "open_id": "ou_194fcfc5e4b78db556a040ff5e42c0",
        "employee_id":"6c486g",
        "session_key": "e3aeb7df000c835365c630dac91bcf",
        "tenant_key":"2c5914ac018f97",
        "access_token":"u-tpwcnx2XzIcq8yHyJ6KL",
        "expires_in":1565512680,
        "refresh_token":"ur-W9dGvBJyVtwZmrwh0vBn"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Auth.Spec.PostMinaV2TokenLoginValidateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}