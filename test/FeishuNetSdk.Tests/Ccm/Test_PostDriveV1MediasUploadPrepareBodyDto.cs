namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 分片上传素材-预上传 请求体
/// <para>接口ID：6979562676003848220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_prepare</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1MediasUploadPrepareBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "file_name": "demo.jpeg",
    "parent_type": "docx_image",
    "parent_node": "doccnFivLCfJfblZjGZtxgabcef",
    "size": 1024,
    "extra": "{\"drive_route_token\":\"doxcnXgNGAtaAraIRVeCfmabcef\"}"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1MediasUploadPrepareBodyDto>(json);
        Assert.IsNotNull(result);
    }
}