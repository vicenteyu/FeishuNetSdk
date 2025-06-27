// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostPerformanceV2ReviewTemplatesQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取评估模板配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Performance;

/// <summary>
/// 测试 获取评估模板配置 请求体
/// <para>接口ID：7351374599659782148</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freview_template%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostPerformanceV2ReviewTemplatesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "review_template_ids": [
        "7343513161666707459"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Performance.PostPerformanceV2ReviewTemplatesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}