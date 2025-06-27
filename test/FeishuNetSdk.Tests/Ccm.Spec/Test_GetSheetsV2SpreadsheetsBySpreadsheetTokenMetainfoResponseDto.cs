// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取表格元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取表格元数据 响应体
/// <para>接口ID：6907569744330227713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/obtain-spreadsheet-metadata</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETMzUjLxEzM14SMxMTN</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "properties": {
            "title": "",
            "ownerUser": 0,
            "sheetCount": 0,
            "revision": 0
        },
        "sheets": [
            {
                "sheetId": "***",
                "title": "***",
                "index": 0,
                "rowCount": 0,
                "columnCount": 0,
                "frozenColCount": 0,
                "frozenRowCount": 0,
                "merges": [
                    {
                        "columnCount": 0,
                        "rowCount": 0,
                        "startColumnIndex": 0,
                        "startRowIndex": 0
                    }
                ],
                "protectedRange": [
                    {
                        "dimension": {
                            "endIndex": 0,
                            "majorDimension": "ROWS",
                            "sheetId": "***",
                            "startIndex": 0
                        },
                        "protectId": "***",
                        "sheetId": "***",
                        "lockInfo": "***"
                    }
                ]
            },
            {
                "blockInfo": {
                    "blockToken": "***",
                    "blockType": "***"
                },
                "columnCount": 0,
                "frozenColCount": 0,
                "frozenRowCount": 0,
                "index": 0,
                "rowCount": 0,
                "sheetId": "***",
                "title": "*** "
            }
        ],
        "spreadsheetToken": "***"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenMetainfoResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}