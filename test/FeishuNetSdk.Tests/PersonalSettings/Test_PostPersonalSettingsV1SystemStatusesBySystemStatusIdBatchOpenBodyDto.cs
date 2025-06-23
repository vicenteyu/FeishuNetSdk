namespace FeishuNetSdk.Tests.PersonalSettings;

/// <summary>
/// 测试 批量开启系统状态 请求体
/// <para>接口ID：7161608966368772099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_open</para>
/// </summary>
[TestClass]
public class Test_PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_list": [
        {
            "user_id": "ou_53edd3282dbc2fdbe5c593cfa5ce82ab",
            "end_time": "1665990378"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.PersonalSettings.PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}