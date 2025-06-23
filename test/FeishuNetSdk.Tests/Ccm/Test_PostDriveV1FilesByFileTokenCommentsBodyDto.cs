namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 添加全文评论 请求体
/// <para>接口ID：6955017385137750017</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCommentsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "reply_list": {
        "replies": [
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
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCommentsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}