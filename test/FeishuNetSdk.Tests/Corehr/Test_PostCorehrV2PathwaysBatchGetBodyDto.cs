// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-01
// ************************************************************************
// <copyright file="Test_PostCorehrV2PathwaysBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取通道信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取通道信息 请求体
/// <para>接口ID：7508634905586991107</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pathway/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpathway%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2PathwaysBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "pathway_ids": [
        "4692446793125560154"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2PathwaysBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}