namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 新建记录 响应体
/// <para>接口ID：7384730094872952860</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/application-object-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fapplication-object-record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "id": "1764024447556775"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1ApplicationsByNamespaceObjectsByObjectApiNameRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}