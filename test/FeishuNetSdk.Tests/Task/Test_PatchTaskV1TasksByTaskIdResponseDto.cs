namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新任务 响应体
/// <para>接口ID：6985127383322378242</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV1TasksByTaskIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "task": {
            "can_edit": true,
            "complete_time": "0",
            "create_time": "1630304148",
            "creator_id": "ou_05b67908bc5d12a086e909a076f7f1b6",
            "description": "多吃水果，多运动，健康生活，快乐工作。",
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
            "custom": "{\"custom_complete\":{\"android\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"ios\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}},\"pc\":{\"href\":\"https://www.feishu.cn/\",\"tip\":{\"zh_cn\":\"你好\",\"en_us\":\"hello\"}}}}",
            "update_time": "1630304149",
            "source": 6,
            "repeat_rule": "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PatchTaskV1TasksByTaskIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}