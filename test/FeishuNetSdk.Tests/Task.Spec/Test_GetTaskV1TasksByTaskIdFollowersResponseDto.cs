namespace FeishuNetSdk.Tests.Task.Spec;

/// <summary>
/// 测试 获取关注人列表 响应体
/// <para>接口ID：6985127383322165250</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-follower/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-follower%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV1TasksByTaskIdFollowersResponseDto : TestBase
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
                "id": "ou_99e1a581b36ecc4862cbfbce473f3123",
                "id_list": [
                    "ou_550cc75233d8b7b9fcbdad65f34433f4"
                ]
            }
        ],
        "page_token": "「上次返回的page_token」",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.Spec.GetTaskV1TasksByTaskIdFollowersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}