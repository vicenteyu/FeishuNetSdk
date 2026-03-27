// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="Test_PostApplicationV7ApplicationsByAppIdPublishBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 提交发布自建应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 提交发布自建应用 请求体
/// <para>接口ID：7621030901518552023</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v7/application-v7/application-publish/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v7%2fapplication-v7%2fapplication-publish%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV7ApplicationsByAppIdPublishBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "mobile_default_ability": "gadget",
    "pc_default_ability": "gadget",
    "remark": "更新了移动端默认应用能力",
    "changelog": "更新了小程序的头像",
    "version": "1.1.1"
}
""";
        var result = Deserialize<FeishuNetSdk.Application.PostApplicationV7ApplicationsByAppIdPublishBodyDto>(json);
        Assert.IsNotNull(result);
    }
}