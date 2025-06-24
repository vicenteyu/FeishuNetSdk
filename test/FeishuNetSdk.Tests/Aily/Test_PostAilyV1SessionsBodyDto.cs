// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAilyV1SessionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 创建会话 请求体
/// <para>接口ID：7358047310868316164</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1SessionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "channel_context": "{}",
    "metadata": "{}"
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1SessionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}