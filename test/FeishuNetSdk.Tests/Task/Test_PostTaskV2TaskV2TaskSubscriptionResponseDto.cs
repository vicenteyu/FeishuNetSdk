// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="Test_PostTaskV2TaskV2TaskSubscriptionResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 订阅任务变更事件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 订阅任务变更事件 响应体
/// <para>接口ID：7645220598528150716</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task_v2/task_subscription</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask_v2%2ftask_subscription</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TaskV2TaskSubscriptionResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "code": 0,
        "msg": "success"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2TaskV2TaskSubscriptionResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}