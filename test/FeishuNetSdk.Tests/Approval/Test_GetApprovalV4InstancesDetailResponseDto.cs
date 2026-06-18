// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-19
//
// Last Modified By : yxr
// Last Modified On : 2026-06-19
// ************************************************************************
// <copyright file="Test_GetApprovalV4InstancesDetailResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取单个审批实例详情（用户级） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 获取单个审批实例详情（用户级） 响应体
/// <para>接口ID：7642253323628432350</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/detail</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fdetail</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4InstancesDetailResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "definition_name": "Payment",
        "start_time": "1564590532967",
        "end_time": "1564590532967",
        "user_id": "f3ta757q",
        "serial_number": "202102060002",
        "department_id": "123456",
        "status": "PENDING",
        "form": "[{\"id\": \"widget1\",\"custom_id\": \"user_info\",\"name\": \"Item application\",\"type\": \"textarea\"},\"value\":\"aaaa\"]",
        "tasks": [
            {
                "id": "1234",
                "user_id": "12345",
                "status": "PENDING",
                "node_id": "46e6d96cfa756980907209209ec03b64",
                "node_name": "开始",
                "type": "AND",
                "start_time": "1564590532967",
                "end_time": "0"
            }
        ],
        "comments": [
            {
                "id": "1234",
                "user_id": "f7cb567e",
                "comment": "ok",
                "create_time": "1564590532967",
                "files": [
                    {
                        "url": "https://xxxxx.xxx",
                        "file_size": 55555,
                        "title": "文件名称",
                        "type": "attachment"
                    }
                ]
            }
        ],
        "operation_records": [
            {
                "type": "PASS",
                "create_time": "1564590532967",
                "user_id": "123456789",
                "cc_user_ids": [
                    "123456789"
                ],
                "task_id": "1234",
                "comment": "ok",
                "node_id": "APPROVAL_240330_4058663",
                "files": [
                    {
                        "url": "https://yyyyy.yyy",
                        "file_size": 777777,
                        "title": "附件名称",
                        "type": "attachment"
                    }
                ]
            }
        ],
        "definition_code": "7C468A54-8745-2245-9675-08B7C63E7A85",
        "reverted": false,
        "instance_code": "81D31358-93AF-92D6-7425-01A5D67C4E71",
        "current_nodes": [
            {
                "node_id": "46e6d96cfa756980907209209ec03b64",
                "node_name": "开始",
                "type": "AND",
                "approvers": [
                    {
                        "task_id": "123456789",
                        "user_id": "ou_c186b6833e2d5fxxxxxx"
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4InstancesDetailResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}