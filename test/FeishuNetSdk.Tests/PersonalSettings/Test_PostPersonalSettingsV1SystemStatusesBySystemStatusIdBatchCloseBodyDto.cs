// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量关闭系统状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.PersonalSettings;

/// <summary>
/// 测试 批量关闭系统状态 请求体
/// <para>接口ID：7161608966368788483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_close</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_close</para>
/// </summary>
[TestClass]
public class Test_PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_list": [
        "ou_53edd3282dbc2fdbe5c593cfa5ce82ab"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.PersonalSettings.PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseBodyDto>(json);
        Assert.IsNotNull(result);
    }
}