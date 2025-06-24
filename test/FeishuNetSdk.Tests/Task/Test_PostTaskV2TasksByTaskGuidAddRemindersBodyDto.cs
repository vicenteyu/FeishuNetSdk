// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2TasksByTaskGuidAddRemindersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加任务提醒 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 添加任务提醒 请求体
/// <para>接口ID：7255580838154813468</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/add_reminders</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_reminders</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksByTaskGuidAddRemindersBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "reminders": [
        {
            "relative_fire_minute": 30
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2TasksByTaskGuidAddRemindersBodyDto>(json);
        Assert.IsNotNull(result);
    }
}