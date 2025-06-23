namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 查询记录 请求体
/// <para>接口ID：7312729248342360068</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/app-table-record/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "view_id": "vewqhz51lk",
  "field_names": [
    "字段1",
    "字段2"
  ],
  "sort": [
    {
      "field_name": "多行文本",
      "desc": true
    }
  ],
  "filter": {
    "conjunction": "and",
    "conditions": [
      {
        "field_name": "职位",
        "operator": "is",
        "value": [
          "初级销售员"
        ]
      },
      {
        "field_name": "销售额",
        "operator": "isGreater",
        "value": [
          "10000.0"
        ]
      }
    ]
  },
  "automatic_fields": false
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdRecordsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}