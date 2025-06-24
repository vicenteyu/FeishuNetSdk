// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCardkitV1CardsByCardIdSettingsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新卡片配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 更新卡片配置 请求体
/// <para>接口ID：7397253002364616707</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/settings</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fsettings</para>
/// </summary>
[TestClass]
public class Test_PatchCardkitV1CardsByCardIdSettingsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "settings": "{\"config\":{\"streaming_mode\":true,\"enable_forward\":true,\"update_multi\":true,\"width_mode\":\"fill\",\"enable_forward_interaction\":false},\"card_link\":{\"url\":\"https://open.feishu.cn\",\"android_url\":\"https://open.feishu.cn\",\"ios_url\":\"https://open.feishu.cn\",\"pc_url\":\"https://open.feishu.cn\"}}",
    "uuid": "191857678434",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PatchCardkitV1CardsByCardIdSettingsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}