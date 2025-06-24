namespace FeishuNetSdk.Tests.HumanAuthentication.Spec;

/// <summary>
/// 测试 查询人脸认证结果 响应体
/// <para>接口ID：6940461543747256348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/query-recognition-result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fface%2fquery-recognition-result</para>
/// </summary>
[TestClass]
public class Test_GetFaceVerifyV1QueryAuthResultResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{ 
    "code": 0, 
    "msg": "ok", 
    "data":{
        "auth_state": 0,
        "auth_timestamp": 1559714887
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.HumanAuthentication.Spec.GetFaceVerifyV1QueryAuthResultResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}