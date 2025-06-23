namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 操作工作表 请求体
/// <para>接口ID：6907569745299439618</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/operate-sheets</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTMzUjL2EzM14iNxMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "requests": [
    {
      "addSheet": {
        "properties": {
          "title": "new_sheet",
          "index": 1
        }
      }
    },
    {
      "copySheet": {
        "source": {
          "sheetId": "2jm6f7"
        },
        "destination": {
          "title": "sheet_copy"
        }
      }
    },
    {
      "deleteSheet": {
        "sheetId": "l8Gdub"
      }
    }
  ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}