namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 写入图片 请求体
/// <para>接口ID：6907568073252585474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-images</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNxYjL1QTM24SN0EjN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{ 
    "range": "Q7PlXT!H7:H7", 
    "image": null,
    "name": "test.png"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}