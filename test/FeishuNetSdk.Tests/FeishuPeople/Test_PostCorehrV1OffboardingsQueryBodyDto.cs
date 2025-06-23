namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询员工离职原因列表 请求体
/// <para>接口ID：7097044451155197956</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1OffboardingsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "active": true,
    "offboarding_reason_unique_identifier": [
        "offboarding_reason_unique_identifier"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1OffboardingsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}