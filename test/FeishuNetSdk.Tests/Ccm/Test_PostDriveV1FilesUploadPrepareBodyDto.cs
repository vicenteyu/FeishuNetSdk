namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 分片上传文件-预上传 请求体
/// <para>接口ID：6979562676003815452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/multipart-upload-file-/upload_prepare</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_prepare</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesUploadPrepareBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "file_name": "test.txt",
    "parent_type": "explorer",
    "parent_node": "fldbcO1UuPz8VwnpPx5a92abcef",
    "size": 1024
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesUploadPrepareBodyDto>(json);
        Assert.IsNotNull(result);
    }
}