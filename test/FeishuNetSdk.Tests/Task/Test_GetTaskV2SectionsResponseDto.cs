// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTaskV2SectionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自定义分组列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取自定义分组列表 响应体
/// <para>接口ID：7259330038033874972</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/section/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2SectionsResponseDto : TestBase
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
                "guid": "e6e37dcc-f75a-5936-f589-12fb4b5c80c2",
                "name": "审核过的任务",
                "is_default": true
            }
        ],
        "page_token": "aWQ9NzEwMjMzMjMxMDE=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2SectionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}