// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutTaskV1TasksByTaskIdCommentsByCommentIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新评论 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新评论 请求体
/// <para>接口ID：6999599891686227970</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutTaskV1TasksByTaskIdCommentsByCommentIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content":"飞流直下三千尺，疑是银河落九天"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PutTaskV1TasksByTaskIdCommentsByCommentIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}