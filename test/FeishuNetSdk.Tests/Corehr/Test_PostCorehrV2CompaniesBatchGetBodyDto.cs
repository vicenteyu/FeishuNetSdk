namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 通过公司 ID 批量获取公司信息 请求体
/// <para>接口ID：7252157701853184028</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CompaniesBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "company_ids": [
        "151515"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CompaniesBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}