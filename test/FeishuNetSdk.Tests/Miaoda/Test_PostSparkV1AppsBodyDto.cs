// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建妙搭应用 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 创建妙搭应用 请求体
/// <para>接口ID：7642228089434950837</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "智能客服助手",
    "app_type": "HTML",
    "description": "提供7×24小时智能对话服务，支持常见问题自动解答与工单流转",
    "icon_url": "https://example.com/app-icons/customer-service.png"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PostSparkV1AppsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}