// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量设置单元格样式  响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量设置单元格样式  响应体
/// <para>接口ID：6907569742383923202</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/batch-set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAzMzUjLwMzM14CMzMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "responses": [
            {
                "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
                "updatedCells": 18,
                "updatedColumns": 3,
                "updatedRange": "6e5ed3!C7:E12",
                "updatedRows": 6
            },
            {
                "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
                "updatedCells": 24,
                "updatedColumns": 3,
                "updatedRange": "4FRjKE!I20:K27",
                "updatedRows": 8
            },
            {
                "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
                "updatedCells": 6,
                "updatedColumns": 3,
                "updatedRange": "9ZFgm1!A1:C2",
                "updatedRows": 2
            }
        ],
        "revision": 90,
        "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
        "totalUpdatedCells": 51,
        "totalUpdatedColumns": 9,
        "totalUpdatedRows": 16
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}