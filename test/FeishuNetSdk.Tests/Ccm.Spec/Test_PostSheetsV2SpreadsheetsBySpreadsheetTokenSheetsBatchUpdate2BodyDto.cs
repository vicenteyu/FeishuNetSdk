// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2BodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新工作表属性 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 更新工作表属性 请求体
/// <para>接口ID：6907569743419473922</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet/update-sheet-properties</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugjMzUjL4IzM14COyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2BodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "requests": [
    {
      "updateSheet": {
        "properties": {
          "sheetId": "1SW8ik",
          "title": "Sales sheet",
          "index": 3,
          "hidden": true,
          "frozenColCount": 8,
          "frozenRowCount": 2,
          "protect": {
            "lock": "LOCK",
            "lockInfo": "privacy info",
            "userIDs": [
              "ou_48d0958ee4b2ab3eaf0b5f6c968abcef"
            ]
          }
        }
      }
    }
  ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenSheetsBatchUpdate2BodyDto>(json);
        Assert.IsNotNull(result);
    }
}