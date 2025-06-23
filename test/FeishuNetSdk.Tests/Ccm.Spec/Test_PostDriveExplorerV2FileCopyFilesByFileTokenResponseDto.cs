namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 复制文档 响应体
/// <para>接口ID：6907569523177127937</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/copy-a-doc-or-sheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTNzUjL2UzM14iN1MTN</para>
/// </summary>
[TestClass]
public class Test_PostDriveExplorerV2FileCopyFilesByFileTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"Success",
    "data":{
        "folderToken":"fldcne0HujIvzDmRF4Pbg0xxxxx",
        "revision":0,
        "token":"shtcnvJ358XqcZq87CCZHdxxxxx",
        "type":"sheet",
        "url":"https://example.feishu.cn/space/sheet/shtcnvJ358XqcZq87CCZHdxxxxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostDriveExplorerV2FileCopyFilesByFileTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}