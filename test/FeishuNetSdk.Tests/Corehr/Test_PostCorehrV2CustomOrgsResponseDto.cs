namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建自定义组织 响应体
/// <para>接口ID：7358017162446503940</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "org_id": "6862995757234914824"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}