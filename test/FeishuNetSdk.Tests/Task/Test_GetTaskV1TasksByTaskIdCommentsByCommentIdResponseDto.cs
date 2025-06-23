namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取评论详情 响应体
/// <para>接口ID：6999599891686244354</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2fget</para>
/// </summary>
[TestClass]
public class Test_GetTaskV1TasksByTaskIdCommentsByCommentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "comment": {
            "content": "加油，奥利给！！",
            "id": "6997691052400312340",
            "parent_id": "0",
            "create_milli_time": "1656483428000"
        }
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV1TasksByTaskIdCommentsByCommentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}