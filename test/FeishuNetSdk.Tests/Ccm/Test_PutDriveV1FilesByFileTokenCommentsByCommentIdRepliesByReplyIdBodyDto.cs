namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新回复的内容 请求体
/// <para>接口ID：6955017385137733633</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutDriveV1FilesByFileTokenCommentsByCommentIdRepliesByReplyIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "content": {
        "elements": [
            {
                "type": "text_run",
                "text_run": {
                    "text": "comment text"
                },
                "docs_link": {
                    "url": "https://example.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef"
                },
                "person": {
                    "user_id": "ou_cc19b2bfb93f8a44db4b4d6eababcef"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PutDriveV1FilesByFileTokenCommentsByCommentIdRepliesByReplyIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}