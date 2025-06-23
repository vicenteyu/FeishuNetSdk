namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新清单 请求体
/// <para>接口ID：7255580838154682396</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2TasklistsByTasklistGuidBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "tasklist": {
        "name": "年会工作任务清单",
        "owner": {
            "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
            "type": "user",
            "role": "owner"
        }
    },
    "update_fields": [
        "owner"
    ],
    "origin_owner_to_role": "editor"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2TasklistsByTasklistGuidBodyDto>(json);
        Assert.IsNotNull(result);
    }
}