namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新评论 响应体
/// <para>接口ID：7255580838154420252</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/comment/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2CommentsByCommentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "comment": {
            "id": "7197020628442939411",
            "content": "这是一条评论",
            "creator": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "creator"
            },
            "reply_to_comment_id": "7166825117308174356",
            "created_at": "1675742789470",
            "updated_at": "1675742789470",
            "resource_type": "task",
            "resource_id": "ccb55625-95d2-2e80-655f-0e40bf67953f"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PatchTaskV2CommentsByCommentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}