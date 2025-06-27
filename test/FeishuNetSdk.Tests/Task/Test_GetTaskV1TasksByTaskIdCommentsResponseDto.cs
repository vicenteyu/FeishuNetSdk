// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTaskV1TasksByTaskIdCommentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取评论列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取评论列表 响应体
/// <para>接口ID：7104611925149581315</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/task-v1/task-comment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2ftask-v1%2ftask-comment%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV1TasksByTaskIdCommentsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": false,
        "items": [
            {
                "content": "评论2",
                "id": "7104224757005533212",
                "parent_id": "0",
                "create_milli_time": "1656483428000"
            },
            {
                "content": "评论1",
                "id": "7104224731582169116",
                "parent_id": "0",
                "create_milli_time": "1656483428000"
            }
        ],
        "page_token": "LTE="
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV1TasksByTaskIdCommentsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}