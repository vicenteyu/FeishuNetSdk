namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 向多个范围写入数据 请求体
/// <para>接口ID：6907569742384381954</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-data-to-multiple-ranges</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjMzUjLxIzM14SMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "valueRanges": [
    {
      "range": "1QXD0s!A1:C1",
      "values": [
        [
          "string1", 1, "http://www.xx.com"
        ]
      ]
    },
    {
      "range": "6e5ed3!A2:C2",
      "values": [
        [
          "string2", 2, "http://www.xx.com"
        ]
      ]
    }
  ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}