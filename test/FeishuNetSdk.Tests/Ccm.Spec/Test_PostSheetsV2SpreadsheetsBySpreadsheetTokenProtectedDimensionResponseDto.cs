// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 增加保护范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 增加保护范围 响应体
/// <para>接口ID：6907569742383988738</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/add-locked-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDNzUjL4QzM14CO0MTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "addProtectedDimension": [
      {
        "dimension": {
          "endIndex": 13,
          "majorDimension": "COLUMNS",
          "sheetId": "Q7PlXT",
          "startIndex": 10
        },
        "lockInfo": "你能编辑",
        "protectId": "7379738014546821122",
        "users": [
          "ou_449b53ad6aee526f7ed311b216aabcef"
        ]
      }
    ]
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedDimensionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}