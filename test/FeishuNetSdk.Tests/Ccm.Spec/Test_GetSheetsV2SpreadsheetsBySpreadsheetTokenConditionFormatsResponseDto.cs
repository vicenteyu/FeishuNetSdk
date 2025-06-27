// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取条件格式 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量获取条件格式 响应体
/// <para>接口ID：6939784115499909148</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/conditionformat/condition-format-get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fconditionformat%2fcondition-format-get</para>
/// </summary>
[TestClass]
public class Test_GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "sheet_condition_formats": [
            {
                "condition_format": {
                    "cf_id": "r9sYuhgAl6",
                    "ranges": [
                        "uEnW3A!C4:C4"
                    ],
                    "rule_type": "timePeriod",
                    "attrs": [
                        {
                            "operator": "is",
                            "time_period": "today"
                        }
                    ],
                    "style": {
                        "back_color": "#d9f5d6",
                        "font": {
                            "bold": true,
                            "italic": false
                        },
                        "fore_color": "#faf1d1",
                        "text_decoration": 3
                    }
                },
                "sheet_id": "uEnW3A"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetSheetsV2SpreadsheetsBySpreadsheetTokenConditionFormatsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}