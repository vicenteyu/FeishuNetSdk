// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新订阅状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新订阅状态 请求体
/// <para>接口ID：7065964758428499996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "is_subscribe": true,
    "file_type": "docx"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}