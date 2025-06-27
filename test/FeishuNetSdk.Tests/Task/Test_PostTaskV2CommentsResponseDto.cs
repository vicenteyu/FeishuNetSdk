// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2CommentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建评论 响应体
/// <para>接口ID：7255580838154616860</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/comment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcomment%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CommentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "comment": {
            "id": "7197020628442939411",
            "content": "这是一条评论",
            "creator": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "creator"
            },
            "reply_to_comment_id": "7166825117308174356",
            "created_at": "1675742789470",
            "updated_at": "1675742789470",
            "resource_type": "task",
            "resource_id": "ccb55625-95d2-2e80-655f-0e40bf67953f"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2CommentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}