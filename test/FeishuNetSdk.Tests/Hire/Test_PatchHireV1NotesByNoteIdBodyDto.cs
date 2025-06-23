namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新备注 请求体
/// <para>接口ID：6950644745484402715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/note/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fnote%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1NotesByNoteIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": "这是一个备注",
    "operator_id": "ou_f476cb099ac9227c9bae09ce46112579",
    "notify_mentioned_user": false,
    "mention_entity_list": [
        {
            "offset": 3,
            "user_id": "on_94a1ee5551019f18cd73d9f111898cf2"
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1NotesByNoteIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}