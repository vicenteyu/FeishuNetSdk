namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 新建文件夹 请求体
/// <para>接口ID：7086652480830914563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/create_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_folder</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesCreateFolderBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "产品优化项目",
    "folder_token": "fldbcO1UuPz8VwnpPx5a92abcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesCreateFolderBodyDto>(json);
        Assert.IsNotNull(result);
    }
}