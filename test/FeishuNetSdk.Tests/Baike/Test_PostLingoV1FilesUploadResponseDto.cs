namespace FeishuNetSdk.Tests.Baike;

/// <summary>
/// 测试 上传图片 响应体
/// <para>接口ID：7249689905697013788</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/file/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2ffile%2fupload</para>
/// </summary>
[TestClass]
public class Test_PostLingoV1FilesUploadResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_token": "boxbcEcmKiD****vgqWTpvdc7jc"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Baike.PostLingoV1FilesUploadResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}