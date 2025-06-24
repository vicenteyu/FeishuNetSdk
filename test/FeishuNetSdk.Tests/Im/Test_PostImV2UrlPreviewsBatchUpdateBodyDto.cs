// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostImV2UrlPreviewsBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新 URL 预览 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im;

/// <summary>
/// 测试 更新 URL 预览 请求体
/// <para>接口ID：7358413940747862020</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v1/url_preview/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2furl_preview%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PostImV2UrlPreviewsBatchUpdateBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "preview_tokens": [
        "952te0c8-9ccf-463d-ad73-593f8f768a5c"
    ],
    "open_ids": [
        "ou_xxx"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Im.PostImV2UrlPreviewsBatchUpdateBodyDto>(json);
        Assert.IsNotNull(result);
    }
}