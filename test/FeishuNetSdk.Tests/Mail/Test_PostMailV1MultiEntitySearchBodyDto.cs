// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-13
//
// Last Modified By : yxr
// Last Modified On : 2026-06-13
// ************************************************************************
// <copyright file="Test_PostMailV1MultiEntitySearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 多实体搜索 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Mail;

/// <summary>
/// 测试 多实体搜索 请求体
/// <para>接口ID：7648865505080413417</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/multi_entity/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmulti_entity%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostMailV1MultiEntitySearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "周会",
    "size": 20
}
""";
        var result = Deserialize<FeishuNetSdk.Mail.PostMailV1MultiEntitySearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}