// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改保护范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 修改保护范围 请求体
/// <para>接口ID：6923123667871612956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/modify-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTM5YjL1ETO24SNxkjN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "requests": [
        {
            "protectId": "6947942538267541505",
            "dimension": {
                "majorDimension": "ROWS",
                "sheetId": "Q7PlXT",
                "startIndex": 2,
                "endIndex": 4
            },
            "editors": {
                "addEditors": [
                    {
                        "memberType": "userId",
                        "memberId": "667338922291111404"
                    }
                ],
                "delEditors": [
                    {
                        "memberType": "userId",
                        "memberId": "667338922291122404"
                    }
                ]
            },
            "lockInfo": "备注信息"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}