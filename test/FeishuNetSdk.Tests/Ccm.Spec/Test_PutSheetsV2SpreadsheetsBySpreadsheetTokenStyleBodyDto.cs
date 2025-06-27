// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设置单元格样式  请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 设置单元格样式  请求体
/// <para>接口ID：6907569523176783873</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/set-cell-style</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukjMzUjL5IzM14SOyMTN</para>
/// </summary>
[TestClass]
public class Test_PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "appendStyle":{
     "range": "1QXD0s!A3:C4",
     "style":{
          "font":{
              "bold":true,
              "italic":true,
              "fontSize":"10pt/1.5",
              "clean":false  
              },    
          "textDecoration":0,
          "formatter":"",
          "hAlign": 0 , 
          "vAlign":0,   
          "foreColor":"#000000",
          "backColor":"#21d11f",
          "borderType":"FULL_BORDER",
          "borderColor": "#ff0000",
          "clean": false 
          }
      }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.Spec.PutSheetsV2SpreadsheetsBySpreadsheetTokenStyleBodyDto>(json);
        Assert.IsNotNull(result);
    }
}