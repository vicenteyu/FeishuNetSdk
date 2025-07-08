// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 追加数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 追加数据 请求体
/// <para>接口ID：6907569524100857857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/append-data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMjMzUjLzIzM14yMyMTN</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "valueRange": {
        "range": "Q7PlXT!A1:B4",
        "values": [
            [
                "===",
                "https://open.feishu.cn"
            ],
            [
                "Hello",
                "https://open.feishu.cn"
            ],
            [
                "World",
                "https://open.feishu.cn"
            ],
            [
                "===",
                "https://open.feishu.cn"
            ]
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesAppendBodyDto>(json);
        Assert.IsNotNull(result);
    }
}