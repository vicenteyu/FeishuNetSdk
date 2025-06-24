// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApprovalV4ExternalTasksResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取三方审批任务状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Approval;

/// <summary>
/// 测试 获取三方审批任务状态 响应体
/// <para>接口ID：7117964632137170947</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/external_task/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fexternal_task%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApprovalV4ExternalTasksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "data": [
            {
                "instance_id": "29075",
                "approval_id": "fwwweffff33111133xxx",
                "approval_code": "B7B65FFE-C2GC-452F-9F0F-9AA8352363D6",
                "status": "PENDING",
                "update_time": "1621863215000",
                "tasks": [
                    {
                        "id": "310",
                        "status": "PENDING",
                        "update_time": "1621863215000"
                    }
                ]
            }
        ],
        "page_token": "nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU",
        "has_more": false
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Approval.GetApprovalV4ExternalTasksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}