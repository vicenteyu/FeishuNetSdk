namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取文件夹元数据 响应体
/// <para>接口ID：6907569524099989505</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/get-folder-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNzUjLwYzM14CM2MTN</para>
/// </summary>
[TestClass]
public class Test_GetDriveExplorerV2FolderByFolderTokenMetaResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
      "id": "7110173013420512356",
      "name": "name",
      "token": "nodbcbHUdOsS613xVzTzFEabcef",
      "createUid": "7103496998321312356",
      "editUid": "7103496998321312356",
      "parentId": "0",
      "ownUid": "7110173013420512356"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetDriveExplorerV2FolderByFolderTokenMetaResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}