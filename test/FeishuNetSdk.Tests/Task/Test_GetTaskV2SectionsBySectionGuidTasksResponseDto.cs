// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTaskV2SectionsBySectionGuidTasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取自定义分组任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 获取自定义分组任务列表 响应体
/// <para>接口ID：7259330038033891356</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/section/tasks</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fsection%2ftasks</para>
/// </summary>
[TestClass]
public class Test_GetTaskV2SectionsBySectionGuidTasksResponseDto : TestBase
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
                "guid": "e297ddff-06ca-4166-b917-4ce57cd3a7a0",
                "summary": "年终总结",
                "completed_at": "1675742789470",
                "start": {
                    "timestamp": "1675454764000",
                    "is_all_day": true
                },
                "due": {
                    "timestamp": "1675454764000",
                    "is_all_day": true
                },
                "members": [
                    {
                        "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                        "type": "user",
                        "role": "editor"
                    }
                ],
                "subtask_count": 1
            }
        ],
        "page_token": "aWQ9NzEwMjMzMjMxMDE=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.GetTaskV2SectionsBySectionGuidTasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}