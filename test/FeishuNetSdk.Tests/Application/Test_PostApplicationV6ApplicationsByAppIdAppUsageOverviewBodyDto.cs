namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用使用概览 请求体
/// <para>接口ID：6995148762798178332</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2foverview</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdAppUsageOverviewBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "date": "2021-07-26",
    "cycle_type": 1,
    "department_id": "od-bb009b4df5431400dc31d3bc8a37e069",
    "ability": "app"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdAppUsageOverviewBodyDto>(json);
        Assert.IsNotNull(result);
    }
}