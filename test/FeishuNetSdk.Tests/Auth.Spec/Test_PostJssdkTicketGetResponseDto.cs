namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 获取 JSAPI 临时授权凭证 响应体
/// <para>接口ID：6911312738021720065</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/authorization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTM5UjL2ETO14iNxkTN%2fh5_js_sdk%2fauthorization</para>
/// </summary>
[TestClass]
public class Test_PostJssdkTicketGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "ok",
    "data": {
        "expire_in": 7200,
        "ticket": "0560604568baf296731aa37f0c8ebe3e049c19d7"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Auth.Spec.PostJssdkTicketGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}