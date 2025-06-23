namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 合并单元格 请求体
/// <para>接口ID：6907569742387707906</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/merge-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukDNzUjL5QzM14SO0MTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "range": "Q7PlXT!F11:G12", 
    "mergeType": "MERGE_ROWS"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenMergeCellsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}