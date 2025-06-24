namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建评论 请求体
/// <para>接口ID：6999599891686293506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdCommentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content":"多喝水，少吃肉",
    "rich_content":"富文本评论[飞书开放平台](https://open.feishu.cn)",
    "parent_id":"0"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdCommentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}