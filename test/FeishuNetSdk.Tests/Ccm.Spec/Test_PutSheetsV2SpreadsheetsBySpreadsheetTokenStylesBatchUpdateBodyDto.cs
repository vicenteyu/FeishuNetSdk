namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 批量设置单元格样式  请求体
/// <para>接口ID：6907569742383923202</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/batch-set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAzMzUjLwMzM14CMzMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "data":[
        {
            "ranges":[
                "6e5ed3!A3:C4",
                "Q7PlXT!A2:B6"
            ],
            "style":{
                "font":{
                    "bold":true,
                    "italic":true,
                    "fontSize":"10pt/1.5",
                    "clean":false
                },
                "textDecoration":0,
                "formatter":"",
                "hAlign":0,
                "vAlign":0,
                "foreColor":"#000000",
                "backColor":"#21d11f",
                "borderType":"FULL_BORDER",
                "borderColor":"#ff0000",
                "clean":false
            }
        },
        {
            "ranges":[
                "Q7PlXT!A2:B6"
            ],
            "style":{
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStylesBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}