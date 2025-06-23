namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用红点 请求体
/// <para>接口ID：7291103260878356482</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app_badge/set</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapp_badge%2fset</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6AppBadgeSetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id": "ou_d317f090b7258ad0372aa53963cda70d",
    "version": "1664360599355",
    "extra": "{}",
    "pc": {
        "web_app": 1,
        "gadget": 2
    },
    "mobile": {
        "web_app": 1,
        "gadget": 2
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostApplicationV6AppBadgeSetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}