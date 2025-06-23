namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询语言信息 请求体
/// <para>接口ID：7424038983966425089</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-language/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-language%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2BasicInfoLanguagesSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "language_id_list": [
        "6863323445740963342"
    ],
    "status_list": [
        1
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2BasicInfoLanguagesSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}