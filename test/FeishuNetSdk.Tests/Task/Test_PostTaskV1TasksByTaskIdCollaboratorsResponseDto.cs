namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 新增执行者 响应体
/// <para>接口ID：6985127383322198018</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-collaborator/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-collaborator%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV1TasksByTaskIdCollaboratorsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "collaborator": {
            "id": "ou_99e1a581b36ecc4862cbfbce473f1234",
            "id_list": [
                "ou_99e1a581b36ecc4862cbfbce473f3123"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV1TasksByTaskIdCollaboratorsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}