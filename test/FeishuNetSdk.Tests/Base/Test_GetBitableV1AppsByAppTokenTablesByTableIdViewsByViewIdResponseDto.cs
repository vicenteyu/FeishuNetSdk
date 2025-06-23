namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 获取视图 响应体
/// <para>接口ID：7177650713441845251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fget</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "view": {
            "view_id": "vewsOleexJ",
            "view_name": "grid",
            "view_type": "grid",
            "property": {
                "filter_info": {
                    "condition_omitted": null,
                    "conditions": [
                        {
                            "condition_id": "conuKMQNNg",
                            "field_id": "fldVioUai1",
                            "field_type": 1,
                            "operator": "is",
                            "value": "[\"text content\"]"
                        }
                    ],
                    "conjunction": "and"
                },
                "hidden_fields": null
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesByTableIdViewsByViewIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}