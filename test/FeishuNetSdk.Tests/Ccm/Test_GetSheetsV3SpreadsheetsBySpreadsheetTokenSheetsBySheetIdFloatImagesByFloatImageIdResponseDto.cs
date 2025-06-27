// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取浮动图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取浮动图片 响应体
/// <para>接口ID：6976178542817247235</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "float_image": {
            "float_image_id": "ye06SS14ph",
            "float_image_token": "boxbcbQsaSqIXsxxxxx1HCPJFbh",
            "range": "ahgsch!A1:A1",
            "width": 100,
            "height": 100,
            "offset_x": 0,
            "offset_y": 0
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}