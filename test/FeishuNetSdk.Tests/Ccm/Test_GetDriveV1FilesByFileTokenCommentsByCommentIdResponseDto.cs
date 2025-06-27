// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDriveV1FilesByFileTokenCommentsByCommentIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取全文评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取全文评论 响应体
/// <para>接口ID：6955017385137782785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesByFileTokenCommentsByCommentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
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
                            "example"
                        ]
                    }
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesByFileTokenCommentsByCommentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}