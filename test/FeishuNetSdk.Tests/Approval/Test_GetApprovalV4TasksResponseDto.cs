// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_GetApprovalV4TasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询审批任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 查询审批任务列表 响应体
/// <para>接口ID：7642253323628448734</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4TasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "tasks": [
            {
                "topic": "1",
                "user_id": "123456",
                "title": "审批",
                "status": "Todo",
                "instance_status": "Running",
                "definition_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
                "initiator": "123456",
                "initiator_name": "张三",
                "task_id": "1234",
                "instance_code": "ABC",
                "definition_group_id": "1234",
                "definition_group_name": "加班",
                "definition_name": "加班",
                "summaries": [
                    {
                        "key": "key",
                        "value": "value"
                    }
                ],
                "instance_external_id": "example_instance_id",
                "task_external_id": "example_task_id",
                "support_api_operate": false,
                "link": "https://www.xxxx.com"
            }
        ],
        "page_token": "example_page_token",
        "has_more": false,
        "count": 10
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4TasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}