// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1NotesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建备注 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 创建备注 请求体
/// <para>接口ID：6950213983267274756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostHireV1NotesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "talent_id": "6916472453069883661",
    "application_id": "6891565253964859661",
    "creator_id": "ou_f476cb099ac9227c9bae09ce46112579",
    "content": "这是一个备注",
    "privacy": 1,
    "notify_mentioned_user": false,
    "mention_entity_list": [
        {
            "offset": 3,
            "user_id": "on_94a1ee5551019f18cd73d9f111898cf2"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1NotesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}