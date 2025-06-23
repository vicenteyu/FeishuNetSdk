namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建评论 响应体
/// <para>接口ID：6999599891686293506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdCommentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "comment": {
            "content": "多喝水，少吃肉",
            "rich_content":"富文本评论飞书开放平台\n",
            "id": "6997680617668214803",
            "parent_id": "0"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdCommentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}