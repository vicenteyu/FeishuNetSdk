namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 添加清单成员 响应体
/// <para>接口ID：7255580838154485788</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/add_members</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fadd_members</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasklistsByTasklistGuidAddMembersResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tasklist": {
            "guid": "cc371766-6584-cf50-a222-c22cd9055004",
            "name": "年会总结工作任务清单",
            "creator": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "creator"
            },
            "owner": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "owner"
            },
            "members": [
                {
                    "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                    "type": "user",
                    "role": "editor"
                }
            ],
            "url": "https://applink.feishu.cn/client/todo/task_list?guid=b45b360f-1961-4058-b338-7f50c96e1b52",
            "created_at": "1675742789470",
            "updated_at": "1675742789470"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2TasklistsByTasklistGuidAddMembersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}