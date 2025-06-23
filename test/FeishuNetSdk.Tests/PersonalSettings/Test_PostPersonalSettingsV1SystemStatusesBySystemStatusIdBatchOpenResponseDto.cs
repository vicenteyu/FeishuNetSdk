namespace FeishuNetSdk.Tests.PersonalSettings;

/// <summary>
/// 测试 批量开启系统状态 响应体
/// <para>接口ID：7161608966368772099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_open</para>
/// </summary>
[TestClass]
public class Test_PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "result_list": [
            {
                "user_id": "ou_53edd3282dbc2fdbe5c593cfa5ce82ab",
                "end_time": "1665990378",
                "result": "success_show"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.PersonalSettings.PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchOpenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}