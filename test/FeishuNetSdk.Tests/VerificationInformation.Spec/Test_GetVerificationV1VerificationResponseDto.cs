namespace FeishuNetSdk.Tests.VerificationInformation.Spec;

/// <summary>
/// 测试 获取认证信息 响应体
/// <para>接口ID：7155320694884614148</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/verification-v1/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fverification-v1%2fverification%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVerificationV1VerificationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "verification": {
            "has_verification": true,
            "name": "无限未来科技公司"
        }
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.VerificationInformation.Spec.GetVerificationV1VerificationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}