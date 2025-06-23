namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取评论列表 响应体
/// <para>接口ID：7255580838154747932</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/comment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2CommentsResponseDto : TestBase
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
        ],
        "page_token": "aWQ9NzEwMjMzMjMxMDE=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2CommentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}