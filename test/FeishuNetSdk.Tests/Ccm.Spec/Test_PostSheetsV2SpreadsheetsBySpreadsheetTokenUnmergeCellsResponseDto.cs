// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 拆分单元格 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 拆分单元格 响应体
/// <para>接口ID：6907569524100055041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/split-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNzUjLwUzM14CM1MTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "spreadsheetToken": "shtcngNygNfuqhxTBf588jabcef"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}