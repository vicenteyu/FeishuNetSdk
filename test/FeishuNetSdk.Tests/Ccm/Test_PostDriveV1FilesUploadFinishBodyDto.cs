namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 分片上传文件-完成上传 请求体
/// <para>接口ID：6979562676003766300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_finish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_finish</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesUploadFinishBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "upload_id": "7111211691345512356",
    "block_num": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesUploadFinishBodyDto>(json);
        Assert.IsNotNull(result);
    }
}