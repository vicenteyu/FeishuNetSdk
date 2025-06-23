namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新视图 请求体
/// <para>接口ID：7177650713441828867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "view_name": "grid",
  "property": {
    "filter_info": {
      "conditions": [
        {
          "field_id": "fldpTw2262",
          "operator": "isGreater",
          "value": "[\"ExactDate\",\"1642672432000\"]"
        }
      ],
      "conjunction": "and"
    }
  },
  "hidden_fields": null
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}