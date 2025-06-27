// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取电子表格信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取电子表格信息 响应体
/// <para>接口ID：7120425077330919452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fget</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV3SpreadsheetsBySpreadsheetTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "spreadsheet": {
            "title": "title",
            "owner_id": "ou_48d0958ee4b2ab3eaf0b5f6c968abcef",
            "token": "Iow7sNNEphp3WbtnbCscPqabcef",
            "url": "https://example.feishu.cn/sheets/Iow7sNNEphp3WbtnbCscPqabcef"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetSheetsV3SpreadsheetsBySpreadsheetTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}