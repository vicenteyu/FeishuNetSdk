namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 批量删除关注人 响应体
/// <para>接口ID：7118952533649227779</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/batch_delete_follower</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask%2fbatch_delete_follower</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdBatchDeleteFollowerResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "followers": [
            "ou_13585843f02bc94923ed17a007cbc9b1",
            "ou_f4506885e436763c36e03c05ef1bd6f8"
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdBatchDeleteFollowerResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}