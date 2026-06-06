// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostTaskV2TasklistsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索清单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 搜索清单 请求体
/// <para>接口ID：7645347118866549703</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasklistsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "测试任务清单",
    "filter": {
        "create_time": {
            "start_time": "2026-03-21T16:15:30+08:00",
            "end_time": "2026-03-21T16:15:30+08:00"
        },
        "user_id": [
            "ou_7890123456abcdef"
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasklistsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}