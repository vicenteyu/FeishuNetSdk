namespace FeishuNetSdk.Tests.Acs.Spec;

/// <summary>
/// 测试 获取单个用户信息 响应体
/// <para>接口ID：6987691292973875201</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/user/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2fuser%2fget</para>
/// </summary>
[TestClass]
public class Test_GetAcsV1UsersByUserIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "user": {
            "feature": {
                "card": 123456,
                "face_uploaded": true
            },
            "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.Spec.GetAcsV1UsersByUserIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}