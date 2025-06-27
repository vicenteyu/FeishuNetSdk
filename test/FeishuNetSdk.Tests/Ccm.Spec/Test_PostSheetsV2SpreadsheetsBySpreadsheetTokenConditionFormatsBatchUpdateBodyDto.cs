// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量更新条件格式 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量更新条件格式 请求体
/// <para>接口ID：6939784115499925532</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-update</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateBodyDto : TestBase
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
                "cf_id": "r9sYuhgAl6",
                "rule_type": "timePeriod",
                "attrs": [
                    {
                        "operator": "is",
                        "time_period": "today",
                        "formula": [],
                        "text": ""
                    }
                ],
                "ranges": [
                    "40a7b0!C3:C3"
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
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}