namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 操作工作表 响应体
/// <para>接口ID：6907569745299439618</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/operate-sheets</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTMzUjL2EzM14iNxMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "msg": "Success",
  "data": {
    "replies": [
      {
        "addSheet": {
          "properties": {
            "sheetId": "l8Gddg",
            "title": "new_sheet",
            "index": 1
          }
        },
        "copySheet": {
          "properties": {
            "sheetId": "dso4jn",
            "title": "sheet_copy",
            "index": 0
          }
        },
        "deleteSheet": {
          "result": true,
          "sheetId": "l8Gdub"
        }
      }
    ]
  }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}