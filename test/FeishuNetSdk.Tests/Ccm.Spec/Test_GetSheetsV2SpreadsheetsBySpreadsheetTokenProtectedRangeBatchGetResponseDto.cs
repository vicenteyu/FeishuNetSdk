namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取保护范围 响应体
/// <para>接口ID：6923123667871596572</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/retrieve-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTM5YjL0ETO24CNxkjN</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "protectedRanges": [
      {
        "dimension": {
          "endIndex": 13,
          "majorDimension": "COLUMNS",
          "sheetId": "aIVj4J",
          "startIndex": 10
        },
        "editors": {
          "users": [
            {
              "memberId": "7307457169426112456",
              "memberType": "userId"
            }
          ]
        },
        "lockInfo": "你能编辑",
        "protectId": "7379738014546821122",
        "sheetId": "aIVj4J"
      },
      {
        "dimension": {
          "endIndex": 14,
          "majorDimension": "COLUMNS",
          "sheetId": "aIVj4J",
          "startIndex": 13
        },
        "editors": {
          "users": [
            {
              "memberId": "7307457169426112456",
              "memberType": "userId"
            }
          ]
        },
        "lockInfo": "你能编辑",
        "protectId": "7379831455515639836",
        "sheetId": "aIVj4J"
      }
    ]
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}