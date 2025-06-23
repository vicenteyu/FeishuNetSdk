namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量删除条件格式 响应体
/// <para>接口ID：6939784115499859996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-delete</para>
/// </summary>
[TestClass]
public class Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "responses": [
            {
                "cf_id": "6hP6Dj6gsd",
                "res_code": 555554047,
                "res_msg": "cfId not exist",
                "sheet_id": "40a7b0"
            }
        ]
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchDeleteResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}