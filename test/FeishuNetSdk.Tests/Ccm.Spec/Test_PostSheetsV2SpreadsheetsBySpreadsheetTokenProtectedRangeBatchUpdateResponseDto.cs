// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改保护范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 修改保护范围 响应体
/// <para>接口ID：6923123667871612956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/modify-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTM5YjL1ETO24SNxkjN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "replies": [
            {
                "protectId": "6947942538267541505",
                "dimension": {
                    "sheetId": "Q7PlXT",
                    "startIndex": 2,
                    "endIndex": 4,
                    "majorDimension": "ROWS"
                },
                "editors": {
                    "addEditors": [
                        {
                            "memberType": "userId",
                            "memberId": "667338922291111404"
                        }
                    ],
                    "delEditors": []
                },
                "lockInfo": "备注信息",
                "sheetId": "Q7PlXT"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}