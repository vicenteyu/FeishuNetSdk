namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 复制文档 请求体
/// <para>接口ID：6907569523177127937</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/copy-a-doc-or-sheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTNzUjL2UzM14iN1MTN</para>
/// </summary>
[TestClass]
public class Test_PostDriveExplorerV2FileCopyFilesByFileTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "type":"objType",
  "dstFolderToken":"string",
  "dstName":"string",
  "commentNeeded":true
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostDriveExplorerV2FileCopyFilesByFileTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}