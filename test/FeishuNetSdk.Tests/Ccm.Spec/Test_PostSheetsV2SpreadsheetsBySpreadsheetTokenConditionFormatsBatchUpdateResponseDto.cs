namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量更新条件格式 响应体
/// <para>接口ID：6939784115499925532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-update</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "responses": [
            {
                "cf_id": "1gJelvenW9",
                "res_code": 0,
                "res_msg": "success",
                "sheet_id": "40a7b0"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}