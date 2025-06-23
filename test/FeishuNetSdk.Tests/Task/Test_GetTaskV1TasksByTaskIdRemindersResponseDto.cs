namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 查询提醒时间列表 响应体
/// <para>接口ID：6985127383322394626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-reminder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-reminder%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV1TasksByTaskIdRemindersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "1",
                "relative_fire_minute": 30
            }
        ],
        "page_token": "「填写上次返回的page_token」",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV1TasksByTaskIdRemindersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}