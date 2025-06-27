// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchTaskV2CommentsByCommentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新评论 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新评论 请求体
/// <para>接口ID：7255580838154420252</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/comment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2CommentsByCommentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "comment": {
        "content": "举杯邀明月，对影成三人"
    },
    "update_fields": [
        "content"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2CommentsByCommentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}