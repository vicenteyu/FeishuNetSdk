namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新动态订阅 请求体
/// <para>接口ID：7288897051646967810</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist-activity_subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "activity_subscription": {
        "name": "Roadmap订阅",
        "subscribers": [
            {
                "id": "oc_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "chat"
            }
        ],
        "include_keys": [
            101
        ],
        "disabled": false
    },
    "update_fields": [
        "name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidBodyDto>(json);
        Assert.IsNotNull(result);
    }
}