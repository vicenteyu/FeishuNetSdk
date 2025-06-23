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
    "image": [137,80,78,71,13,10,26,10,0,0,0,13,73,72,68,82,0,0,0,2,0,0,0,1,1,0,0,0,0,220,89,66,39,0,0,0,2,116,82,78,83,0,0,118,147,205,56,0,0,0,10,73,68,65,84,8,215,99,104,0,0,0,130,0,129,221,67,106,244,0,0,0,0,73,69,78,68,174,66,96,130],
    "name": "test.png"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto>(json);
        Assert.IsNotNull(result);
    }
}