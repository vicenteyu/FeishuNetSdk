namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新视图 响应体
/// <para>接口ID：7177650713441828867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
  "code": 0,
  "data": {
    "view": {
      "property": {
        "filter_info": {
          "condition_omitted": null,
          "conditions": [
            {
              "condition_id": "conaklRhDC",
              "field_id": "fldpTw2262",
              "field_type": 5,
              "operator": "isGreater",
              "value": "[\"ExactDate\",1642672432000]"
            }
          ],
          "conjunction": "and"
        },
        "hidden_fields": null,
        "hierarchy_config": null
      },
      "view_id": "vewKecDsBf",
      "view_name": "grid",
      "view_type": "grid"
    }
  },
  "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}