// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增多条记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增多条记录 请求体
/// <para>接口ID：6952707657162604546</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fbatch_create</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "records": [
    {
      "fields": {
        "文本": "文本内容",
        "条码": "qawqe",
        "数字": 100,
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
            "id": "ou_2910013f1e6456f16a0ce75ede950a0a"
          },
          {
            "id": "ou_e04138c9633dd0d2ea166d79f548ab5d"
          }
        ],
        "群组": [
          {
            "id": "oc_cd07f55f14d6f4a4f1b51504e7e97f48"
          }
        ],
        "电话号码": "13026162666",
        "超链接": {
          "text": "飞书多维表格官网",
          "link": "https://www.feishu.cn/product/base"
        },
        "附件": [
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
    },
    {
      "fields": {
        "文本": "文本内容2"
      }
    }
  ]
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsBatchCreateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}