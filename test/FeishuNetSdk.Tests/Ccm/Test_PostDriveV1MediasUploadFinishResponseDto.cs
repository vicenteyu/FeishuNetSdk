namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 分片上传素材-完成上传 响应体
/// <para>接口ID：6979562676003880988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_finish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_finish</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1MediasUploadFinishResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_token": "boxcnrHpsg1QDqXAAAyachabcef"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1MediasUploadFinishResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}