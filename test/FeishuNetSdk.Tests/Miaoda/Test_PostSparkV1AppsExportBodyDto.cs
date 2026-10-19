// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-10-17
//
// Last Modified By : yxr
// Last Modified On : 2026-10-17
// ************************************************************************
// <copyright file="Test_PostSparkV1AppsExportBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 导出妙搭应用代码包 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 导出妙搭应用代码包 请求体
/// <para>接口ID：7692846107466206181</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/export</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fexport</para>
/// </summary>
[TestClass]
public class Test_PostSparkV1AppsExportBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "app_id": "app_4k6af8utt2s0n",
    "release_id": "7687553819701775556"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PostSparkV1AppsExportBodyDto>(json);
        Assert.IsNotNull(result);
    }
}