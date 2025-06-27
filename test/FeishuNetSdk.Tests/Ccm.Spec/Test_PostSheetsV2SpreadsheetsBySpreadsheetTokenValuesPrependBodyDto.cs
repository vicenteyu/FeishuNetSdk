// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 插入数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 插入数据 请求体
/// <para>接口ID：6907569742384398338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/prepend-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjMzUjLyIzM14iMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "valueRange": {
    "range": "Q7PlXT!C6:F9",
    "values": [
      [
        "string",
        1,
        "http://www.xx.com"
      ]
    ]
  }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesPrependBodyDto>(json);
        Assert.IsNotNull(result);
    }
}