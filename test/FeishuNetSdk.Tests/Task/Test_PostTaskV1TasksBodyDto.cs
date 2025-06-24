// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV1TasksBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建任务 请求体
/// <para>接口ID：6985127383322296322</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "summary": "每天喝八杯水，保持身心愉悦",
    "description": "多吃水果，多运动，健康生活，快乐工作。",
    "rich_summary": "富文本标题[飞书开放平台](https://open.feishu.cn)",
    "rich_description": "富文本备注[飞书开放平台](https://open.feishu.cn)",
    "extra": "dGVzdA==",
    "due": {
        "time": "1623124318",
        "timezone": "Asia/Shanghai",
        "is_all_day": false
    },
    "origin": {
        "platform_i18n_name": "{\"zh_cn\": \"IT 工作台\", \"en_us\": \"IT Workspace\"}",
        "href": {
            "url": "https://support.feishu.com/internal/foo-bar",
            "title": "反馈一个问题，需要协助排查"
        }
    },
    "can_edit":true,
    "custom": "{\"custom_complete\":{\"android\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"ios\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"pc\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}}}}",
    "follower_ids": ["ou_13585843f02bc94923ed17a007cbc9b1", "ou_219a0611de2a639aa939ee97013f37a5"],
    "collaborator_ids": ["ou_13585843f02bc94923ed17a007cbc9b1", "ou_219a0611de2a639aa939ee97013f37a5"],
    "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV1TasksBodyDto>(json);
        Assert.IsNotNull(result);
    }
}