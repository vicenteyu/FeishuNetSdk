// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PatchCorehrV2PathwaysByPathwayIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新通道 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新通道 请求体
/// <para>接口ID：7508634905587023875</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2PathwaysByPathwayIdBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2PathwaysByPathwayIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}