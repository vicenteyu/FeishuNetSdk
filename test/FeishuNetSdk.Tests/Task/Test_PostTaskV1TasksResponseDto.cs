// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV1TasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建任务 响应体
/// <para>接口ID：6985127383322296322</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "task": {
            "complete_time": "0",
            "create_time": "1630304148",
            "creator_id": "ou_05b67908bc5d12a086e909a076f7f1b6",
            "description": "多吃水果，多运动，健康生活，快乐工作。",
            "rich_description": "富文本备注飞书开放平台\n",
            "due": {
                "time": "1623124318",
                "timezone": "Asia/Shanghai"
            },
            "extra": "dGVzdA==",
            "id": "68c9b9ff-d5b5-41bf-b407-6d956f23143f",
            "origin": {
                "href": {
                    "title": "反馈一个问题，需要协助排查",
                    "url": "https://support.feishu.com/internal/foo-bar"
                },
                "platform_i18n_name": "{\"en_us\":\"IT Workspace\",\"zh_cn\":\"IT 工作台\"}"
            },
            "summary": "每天喝八杯水，保持身心愉悦",
            "rich_summary": "富文本标题飞书开放平台\n",
            "custom": "{\"custom_complete\":{\"android\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"ios\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"pc\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}}}}",
            "update_time": "1630304149",
            "source": 6,
            "collaborators": [
                {
                    "id": "ou_13585843f02bc94923ed17a007cbc9b1"
                },
                {
                    "id": "ou_219a0611de2a639aa939ee97013f37a5"
                }
            ],
            "followers": [
                {
                    "id": "ou_13585843f02bc94923ed17a007cbc9b1"
                },
                {
                    "id": "ou_219a0611de2a639aa939ee97013f37a5"
                }
            ],
            "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV1TasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}