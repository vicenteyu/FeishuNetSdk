// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="Test_PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加回复 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 添加回复 响应体
/// <para>接口ID：7625922449226419390</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "content": {
            "elements": [
                {
                    "type": "docs_link",
                    "text_run": {
                        "text": "reply text"
                    },
                    "docs_link": {
                        "url": "https://example.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef"
                    },
                    "person": {
                        "user_id": "ou_cc19b2bfb93f8a44db4b4d6eab2abcef"
                    }
                }
            ]
        },
        "reply_id": "6916106xxxxx4512356",
        "user_id": "ou_cc19b2bfb93f8a44db4b4d6eab2abcef",
        "create_time": 1610281603,
        "update_time": 1610281603,
        "extra": {
            "image_list": [
                "xfsfseewewabcef"
            ]
        },
        "reactions": []
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}