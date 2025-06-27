// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增一个数据表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增一个数据表 请求体
/// <para>接口ID：6960166873968541699</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "table": {
    "name": "数据表名称",
    "default_view_name": "默认的表格视图",
    "fields": [
      {
        "field_name": "索引字段",
        "type": 1
      },
      {
        "field_name": "单选",
        "type": 3,
        "ui_type": "SingleSelect",
        "property": {
          "options": [
            {
              "name": "Enabled",
              "color": 0
            },
            {
              "name": "Disabled",
              "color": 1
            },
            {
              "name": "Draft",
              "color": 2
            }
          ]
        }
      }
    ]
  }
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}