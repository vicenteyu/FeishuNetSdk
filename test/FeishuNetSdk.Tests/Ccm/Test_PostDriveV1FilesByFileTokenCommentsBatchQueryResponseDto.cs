namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 批量获取评论 响应体
/// <para>接口ID：7123144042921590786</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCommentsBatchQueryResponseDto : TestBase
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
                "comment_id": "6916106822734512356",
                "user_id": "ou_cc19b2bfb93f8a44db4b4d6eababcef",
                "create_time": 1610281603,
                "update_time": 1610281603,
                "is_solved": false,
                "solved_time": 1610281603,
                "solver_user_id": "null",
                "has_more": false,
                "page_token": "6916106822734512356",
                "is_whole": true,
                "quote": "划词评论引用内容",
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
                            },
                            "reply_id": "6916106822734512356",
                            "user_id": "ou_cc19b2bfb93f8a44db4b4d6eab2abcef",
                            "create_time": 1610281603,
                            "update_time": 1610281603,
                            "extra": {
                                "image_list": [
                                    "xfsfseewewabcef"
                                ]
                            }
                        }
                    ]
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCommentsBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}