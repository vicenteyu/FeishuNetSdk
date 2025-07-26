// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增记录 请求体
/// <para>接口ID：6952707657162522626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "fields": {
    "任务名称": "拜访潜在客户",
    "条码": "+$$3170930509104X512356",
    "工时": 10,
    "货币": 3,
    "评分": 3,
    "进度": 0.25,
    "单选": "选项1",
    "多选": [
      "选项1",
      "选项2"
    ],
    "日期": 1674206443000,
    "复选框": true,
    "人员": [
      {
        "id": "ou_2910013f1e6456f16a0ce75ede9abcef"
      },
      {
        "id": "ou_e04138c9633dd0d2ea166d79f54abcef"
      }
    ],
    "群组": [
      {
        "id": "oc_cd07f55f14d6f4a4f1b51504e7e97f48"
      }
    ],
    "电话号码": "1302616xxxx",
    "超链接": {
      "text": "飞书多维表格官网",
      "link": "https://www.feishu.cn/product/base"
    },
    "附件": [
      {
        "file_token": "DRiFbwaKsoZaLax4WKZbEGCccoe"
      },
      {
        "file_token": "BZk3bL1Enoy4pzxaPL9bNeKqcLe"
      },
      {
        "file_token": "EmL4bhjFFovrt9xZgaSbjJk9c1b"
      },
      {
        "file_token": "Vl3FbVkvnowlgpxpqsAbBrtFcrd"
      }
    ],
    "单向关联": [
      "recHTLvO7x",
      "recbS8zb2m"
    ],
    "双向关联": [
      "recHTLvO7x",
      "recbS8zb2m"
    ],
    "地理位置": "116.397755,39.903179"
  }
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}