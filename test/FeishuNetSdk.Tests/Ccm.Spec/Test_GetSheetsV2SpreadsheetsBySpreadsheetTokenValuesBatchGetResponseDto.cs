// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 读取多个范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 读取多个范围 响应体
/// <para>接口ID：6907569743420325890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/reading-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTMzUjL5EzM14SOxMTN</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "revision": 87,
        "spreadsheetToken": "shtcngNygNfuqhxTBf588jabcef",
        "totalCells": 6,
        "valueRanges": [
            {
                "majorDimension": "ROWS",
                "range": "6e5ed3!A2:B3",
                "revision": 87,
                "values": [
                    [
                        "World",
                        1
                    ],
                    [
                        5,
                        6
                    ]
                ]
            },
            {
                "majorDimension": "ROWS",
                "range": "4FRjKE!B1:B2",
                "revision": 87,
                "values": [
                    [
                        "test"
                    ],
                    [
                        "test"
                    ]
                ]
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}