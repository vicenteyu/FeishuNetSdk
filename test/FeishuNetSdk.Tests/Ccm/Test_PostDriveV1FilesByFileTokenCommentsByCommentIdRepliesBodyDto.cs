// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-04-11
// ************************************************************************
// <copyright file="Test_PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 添加回复 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 添加回复 请求体
/// <para>接口ID：7625922449226419390</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment-reply/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
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
                    "user_id": "ou_cc19b2bfb93f8a44db4b4d6eababcef"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCommentsByCommentIdRepliesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}