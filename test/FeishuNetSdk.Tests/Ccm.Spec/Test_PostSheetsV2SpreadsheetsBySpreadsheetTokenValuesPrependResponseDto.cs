// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 插入数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 插入数据 响应体
/// <para>接口ID：6907569742384398338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/prepend-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjMzUjLyIzM14iMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}