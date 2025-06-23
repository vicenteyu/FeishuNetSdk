namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 获取旧版文档富文本内容 响应体
/// <para>接口ID：6908984614439845890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/content/get-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDM2YjL1AjN24SNwYjN</para>
/// </summary>
[TestClass]
public class Test_GetDocV2ByDocTokenContentResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "content": "{}",
        "revision": 1000  
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.GetDocV2ByDocTokenContentResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}