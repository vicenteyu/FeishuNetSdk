// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAcsV1RuleExternalDeviceBindBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 设备绑定权限组 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs;

/// <summary>
/// 测试 设备绑定权限组 请求体
/// <para>接口ID：7321978105899073564</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/rule_external/device_bind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fdevice_bind</para>
/// </summary>
[TestClass]
public class Test_PostAcsV1RuleExternalDeviceBindBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "device_id": "6939433228970082593",
    "rule_ids": [
        "7298933941867135276"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Acs.PostAcsV1RuleExternalDeviceBindBodyDto>(json);
        Assert.IsNotNull(result);
    }
}