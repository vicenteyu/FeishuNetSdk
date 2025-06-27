// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDocV2ByDocTokenSheetMetaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取旧版文档中的电子表格元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取旧版文档中的电子表格元数据 响应体
/// <para>接口ID：6907569744330833921</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/document/obtain-sheet-meta-info-in-doc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuADOzUjLwgzM14CM4MTN</para>
/// </summary>
[TestClass]
public class Test_GetDocV2ByDocTokenSheetMetaResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "spreadsheetToken": "string",
        "sheets": [
            {
                "sheetId": "string",
                "title": "string",
                "index": 0,
                "rowCount": 4,
                "columnCount": 4
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetDocV2ByDocTokenSheetMetaResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}