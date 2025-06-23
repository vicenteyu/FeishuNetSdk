namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取回复信息 响应体
/// <para>接口ID：7123144042921607170</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto : TestBase
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
        ],
        "page_token": "6916106822734512356",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}