namespace FeishuNetSdk.Tests.HumanAuthentication.Spec;

/// <summary>
/// 测试 裁剪人脸图片 响应体
/// <para>接口ID：6940461543747289116</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/facial-image-cropping</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fface%2ffacial-image-cropping</para>
/// </summary>
[TestClass]
public class Test_PostFaceVerifyV1CropFaceImageResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{ 
    "code": 0, 
    "msg": "ok"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.HumanAuthentication.Spec.PostFaceVerifyV1CropFaceImageResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}