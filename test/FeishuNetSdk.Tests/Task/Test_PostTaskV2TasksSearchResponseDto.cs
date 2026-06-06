// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="Test_PostTaskV2TasksSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 搜索任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 搜索任务 响应体
/// <para>接口ID：7645347118866533319</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2TasksSearchResponseDto : TestBase
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
                "id": "123456789",
                "display_info": "任务<h>搜索</h>",
                "meta_data": {
                    "app_link": "https://applink.feishu.cn/client/todo/detail?guid=ed03112a-0a25-451e-8453-ba1d80cc1b7e",
                    "avatar": "https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg",
                    "description": "这是一个用来测试的任务"
                }
            }
        ],
        "total": 10,
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2TasksSearchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}