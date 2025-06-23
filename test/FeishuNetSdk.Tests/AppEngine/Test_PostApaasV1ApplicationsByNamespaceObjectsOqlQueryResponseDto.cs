namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 执行 OQL 响应体
/// <para>接口ID：7384730094873002012</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/oql_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object%2foql_query</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsOqlQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "columns": [
            "_id"
        ],
        "rows": "[       {         \"_name\": \"Sample Text\",         \"_id\": 1234567890       }     ]"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsOqlQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}