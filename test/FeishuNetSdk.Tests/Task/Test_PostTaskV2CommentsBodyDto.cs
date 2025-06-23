namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建评论 请求体
/// <para>接口ID：7255580838154616860</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CommentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": "这是一条评论。",
    "reply_to_comment_id": "6937231762296684564",
    "resource_type": "task",
    "resource_id": "ccb55625-95d2-2e80-655f-0e40bf67953f"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2CommentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}