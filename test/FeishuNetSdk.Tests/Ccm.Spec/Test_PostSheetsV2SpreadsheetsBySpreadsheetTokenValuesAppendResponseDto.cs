// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 追加数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 追加数据 响应体
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "revision": 18,
    "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
    "tableRange": "6e5ed3!A1:C1",
    "updates": {
      "revision": 18,
      "spreadsheetToken": "GQJHsEgcoh2qDHtSxeKcJCabcef",
      "updatedCells": 3,
      "updatedColumns": 3,
      "updatedRange": "6e5ed3!A1:C1",
      "updatedRows": 1
    }
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}