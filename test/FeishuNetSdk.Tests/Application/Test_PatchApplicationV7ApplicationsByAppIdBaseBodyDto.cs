// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PatchApplicationV7ApplicationsByAppIdBaseBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新应用基础信息配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 更新应用基础信息配置 请求体
/// <para>接口ID：7621030901518584791</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-base/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-base%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchApplicationV7ApplicationsByAppIdBaseBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "i18ns": [
        {
            "i18n_key": "zh_cn",
            "name": "应用名称",
            "description": "应用描述",
            "help_use": "https://www.example.com"
        }
    ],
    "avatar_url": "https://s3-imfile.feishucdn.com/static-resource/v1/v2_953a8fc1-50bd-4b2e-87e2-b09e47dba23g",
    "homepage_url": "https://open.feishu.cn/"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PatchApplicationV7ApplicationsByAppIdBaseBodyDto>(json);
        Assert.IsNotNull(result);
    }
}