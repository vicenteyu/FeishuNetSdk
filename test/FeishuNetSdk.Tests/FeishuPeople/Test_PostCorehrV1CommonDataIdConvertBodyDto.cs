namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 ID 转换 请求体
/// <para>接口ID：7338765273649348612</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/common_data-id/convert</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcommon_data-id%2fconvert</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1CommonDataIdConvertBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "ids": [
        "6891251722631891445"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1CommonDataIdConvertBodyDto>(json);
        Assert.IsNotNull(result);
    }
}