// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApaasV1UserTaskQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询人工任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询人工任务 响应体
/// <para>接口ID：7446337145820315652</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostApaasV1UserTaskQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "count": "10",
        "tasks": [
            {
                "task_id": "1234",
                "task_start_time": "1234",
                "workflow_instance": {
                    "id": "1234",
                    "label": [
                        {
                            "language_code": "2052",
                            "text": "任务名称"
                        }
                    ],
                    "status": "in_process"
                },
                "initiator": {
                    "user_id": "1234",
                    "name": "发起人名称"
                },
                "summarys": [
                    {
                        "file_key": {
                            "language_code": "2052",
                            "text": "摘要名称"
                        },
                        "file_value": [
                            {
                                "language_code": "2052",
                                "text": "摘要值"
                            }
                        ]
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.PostApaasV1UserTaskQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}