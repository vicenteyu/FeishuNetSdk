namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 删除自定义组织 请求体
/// <para>接口ID：7358017162446487556</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/delete_org</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fdelete_org</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsDeleteOrgBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "org_id": "6862995757234914824",
    "object_api_name": "custom_org_01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsDeleteOrgBodyDto>(json);
        Assert.IsNotNull(result);
    }
}