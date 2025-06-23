namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 上传文件 响应体
/// <para>接口ID：6979562676003864604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_all</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesUploadAllResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesUploadAllResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}