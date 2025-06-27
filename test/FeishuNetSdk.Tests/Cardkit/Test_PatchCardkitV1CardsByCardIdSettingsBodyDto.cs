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
/// 测试 更新卡片实体配置 请求体
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
    "settings": "{\"config\":{\"streaming_mode\":true,\"streaming_config\":{\"print_frequency_ms\":{\"default\":70,\"android\":70,\"ios\":70,\"pc\":70},\"print_step\":{\"default\":1,\"android\":1,\"ios\":1,\"pc\":1},\"print_strategy\":\"fast\"}}}",
    "uuid": "a0d69e20-1dd1-458b-k525-dfeca4015204",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.PatchCardkitV1CardsByCardIdSettingsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}