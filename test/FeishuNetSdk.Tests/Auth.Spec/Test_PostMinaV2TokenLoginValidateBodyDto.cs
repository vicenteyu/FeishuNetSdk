namespace FeishuNetSdk.Tests.Auth.Spec;

/// <summary>
/// 测试 获取 user_access_token（小程序） 请求体
/// <para>接口ID：6907569745298817026</para>
/// <para>文档地址：https://open.feishu.cn/document/client-docs/gadget/-web-app-api/open-ability/login/code2session</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuYjL24iN%2fukjM04SOyQjL5IDN</para>
/// </summary>
[TestClass]
public class Test_PostMinaV2TokenLoginValidateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
     "code": "2ef0bb04e272d274"
}
""";
        var result = Deserialize<FeishuNetSdk.Auth.Spec.PostMinaV2TokenLoginValidateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}