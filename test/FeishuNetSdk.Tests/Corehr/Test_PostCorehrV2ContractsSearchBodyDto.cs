namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 搜索合同 请求体
/// <para>接口ID：7248868628551303172</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/contract/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcontract%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2ContractsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employment_id_list": [
        "7140964208476371111"
    ],
    "contract_id_list": [
        "7140964208476372371"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2ContractsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}