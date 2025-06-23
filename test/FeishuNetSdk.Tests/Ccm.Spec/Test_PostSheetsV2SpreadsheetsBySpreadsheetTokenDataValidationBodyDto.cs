namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 设置下拉列表 请求体
/// <para>接口ID：6943917246700290050</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/set-dropdown</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fset-dropdown</para>
/// </summary>
[TestClass]
public class Test_PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "range":"yuNGtr!A2:A100",
    "dataValidationType":"list",
    "dataValidation":{
        "conditionValues":["2", "89", "3","2"],
        "options":{
            "multipleValues":true,
            "highlightValidData":true,
            "colors":["#1FB6C1", "#F006C2", "#FB16C3","#FFB6C1"]
        }
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PostSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto>(json);
        Assert.IsNotNull(result);
    }
}