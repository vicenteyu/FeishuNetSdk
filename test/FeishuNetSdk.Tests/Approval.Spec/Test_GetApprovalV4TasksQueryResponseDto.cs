// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApprovalV4TasksQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询用户的任务列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval.Spec;

/// <summary>
/// 测试 查询用户的任务列表 响应体
/// <para>接口ID：6986936689592549378</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2ftask%2fquery</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4TasksQueryResponseDto : TestBase
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
                "user_id": "example_user_id",
                "title": "任务题目示例",
                "urls": {
                    "helpdesk": "https://blabla",
                    "mobile": "https://blabla",
                    "pc": "https://blabla"
                },
                "process_external_id": "example_instance_id",
                "task_external_id": "example_task_id",
                "status": "Todo",
                "process_status": "Running",
                "definition_code": "000000-00000000000000-0example",
                "initiators": [
                    "starter"
                ],
                "initiator_names": [
                    "发起人姓名"
                ],
                "task_id": "1212564555454",
                "process_id": "1214564545474",
                "process_code": "123e4567-e89b-12d3-a456-426655440000",
                "definition_group_id": "1212564555454",
                "definition_group_name": "流程定义名称",
                "definition_id": "1212564555454",
                "definition_name": "流程定义组名称"
            }
        ],
        "page_token": "example_page_token",
        "has_more": true,
        "count": {
            "total": 123,
            "has_more": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.Spec.GetApprovalV4TasksQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}