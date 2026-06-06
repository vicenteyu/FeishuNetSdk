// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostTaskV2TasksSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 搜索任务 请求体
/// <para>接口ID：7645347118866533319</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "测试任务",
    "filter": {
        "creator_ids": [
            "ou_7890123456abcdef"
        ],
        "assignee_ids": [
            "ou_7890123456abcdef"
        ],
        "is_completed": false,
        "due_time": {
            "start_time": "2026-03-21T16:15:30+08:00",
            "end_time": "2026-03-21T16:15:30+08:00"
        },
        "follower_ids": [
            "ou_7890123456abcdef"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}