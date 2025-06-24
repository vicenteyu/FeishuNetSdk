// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量关闭系统状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.PersonalSettings;

/// <summary>
/// 测试 批量关闭系统状态 响应体
/// <para>接口ID：7161608966368788483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/personal_settings-v1/system_status/batch_close</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpersonal_settings-v1%2fsystem_status%2fbatch_close</para>
/// </summary>
[TestClass]
public class Test_PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseResponseDto : TestBase
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
                "result": "success"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.PersonalSettings.PostPersonalSettingsV1SystemStatusesBySystemStatusIdBatchCloseResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}