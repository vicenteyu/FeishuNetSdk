namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新任务 请求体
/// <para>接口ID：6985127383322378242</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV1TasksByTaskIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "task": {
        "summary": "每天喝八杯水，保持身心愉悦",
        "description": "多吃水果，多运动，健康生活，快乐工作。",
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
        "can_edit": true,
        "custom": "{\"custom_complete\":{\"android\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"ios\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"pc\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}}}}",
        "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR"
    },
    "update_fields": ["summary"]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV1TasksByTaskIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}