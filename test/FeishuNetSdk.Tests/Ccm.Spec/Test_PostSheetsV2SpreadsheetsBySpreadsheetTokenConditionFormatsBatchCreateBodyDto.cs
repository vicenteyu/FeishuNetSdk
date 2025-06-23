namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量创建条件格式 请求体
/// <para>接口ID：6939784115499892764</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-set</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-set</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "sheet_condition_formats": [
        {
            "sheet_id": "40a7b0",
            "condition_format": {
                "ranges": [
                    "40a7b0!C3:C3"
                ],
                "rule_type": "timePeriod",
                "attrs": [
                    {
                        "operator": "is",
                        "time_period": "today", // rule_type 为 timePeriod 时必填
                        "formula": ["\"aaaaa\""], // rule_type 为 cellIs 时必填；若其中是文本，则需要用 "" 包裹并转义
                        "text": "" // rule_type 为 containsText 时必填
                    }
                ],
                "style": {
                    "font": {
                        "bold": true,
                        "italic": true
                    },
                    "fore_color": "#faf1d1",
                    "back_color": "#d9f5d6",
                    "text_decoration": 3
                }
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}