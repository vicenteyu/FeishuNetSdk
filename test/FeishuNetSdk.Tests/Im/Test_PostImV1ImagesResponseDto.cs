namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 上传图片 响应体
/// <para>接口ID：6946222931479445505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/image/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fimage%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostImV1ImagesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "image_key": "img_v2_xxx"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Im.PostImV1ImagesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}