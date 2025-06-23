namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 获取记录详情 响应体
/// <para>接口ID：7384730094873018396</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "item": "{}"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsByIdQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}