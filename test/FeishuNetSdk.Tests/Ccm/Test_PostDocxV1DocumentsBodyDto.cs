namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建文档 请求体
/// <para>接口ID：7068199542315204636</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDocxV1DocumentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "folder_token": "fldcnqquW1svRIYVT2Np6Iabcef",
    "title": "一篇新的文档"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDocxV1DocumentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}