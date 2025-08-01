// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2PathwaysBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建通道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建通道 请求体
/// <para>接口ID：7508634905586958339</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PathwaysBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": "A01234",
    "names": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "descriptions": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PathwaysBodyDto>(json);
        Assert.IsNotNull(result);
    }
}