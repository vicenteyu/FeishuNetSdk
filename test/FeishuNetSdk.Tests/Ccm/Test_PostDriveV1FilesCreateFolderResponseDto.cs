namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 新建文件夹 响应体
/// <para>接口ID：7086652480830914563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/create_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_folder</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesCreateFolderResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "token": "fldbcddUuPz8VwnpPx5oc2abcef",
        "url": "https://feishu.cn/drive/folder/fldbcddUuPz8VwnpPx5oc2abcef"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesCreateFolderResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}