namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新评论 响应体
/// <para>接口ID：6999599891686227970</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutTaskV1TasksByTaskIdCommentsByCommentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "comment": {
            "content": "飞流直下三千尺，疑是银河落九天",
            "id": "6997691052400312340",
            "parent_id": "0"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PutTaskV1TasksByTaskIdCommentsByCommentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}