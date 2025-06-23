namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取动态订阅 响应体
/// <para>接口ID：7288897051647016962</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist-activity_subscription/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fget</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "activity_subscription": {
            "guid": "d19e3a2a-edc0-4e4e-b7cc-950e162b53ae",
            "name": "Roadmap订阅",
            "subscribers": [
                {
                    "id": "oc_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                    "type": "chat",
                    "role": "editor"
                }
            ],
            "include_keys": [
                101
            ],
            "disabled": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}