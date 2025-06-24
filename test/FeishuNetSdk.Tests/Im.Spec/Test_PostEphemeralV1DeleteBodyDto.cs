// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostEphemeralV1DeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除仅特定人可见的消息卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Im.Spec;

/// <summary>
/// 测试 删除仅特定人可见的消息卡片 请求体
/// <para>接口ID：6907569742384316418</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/delete-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITOyYjLykjM24iM5IjN</para>
/// </summary>
[TestClass]
public class Test_PostEphemeralV1DeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
   "message_id": "om_xxxxxxxxxxxx"
}
""";
        var result = Deserialize<FeishuNetSdk.Im.Spec.PostEphemeralV1DeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}