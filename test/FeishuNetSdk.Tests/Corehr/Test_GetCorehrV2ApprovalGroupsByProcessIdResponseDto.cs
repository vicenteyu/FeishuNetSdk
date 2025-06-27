// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetCorehrV2ApprovalGroupsByProcessIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 根据流程 ID 查询组织架构调整记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 根据流程 ID 查询组织架构调整记录 响应体
/// <para>接口ID：7317581509003755524</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2ApprovalGroupsByProcessIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approval_group": {
            "approval_group_id": "6991776076699549697",
            "process_id": "6991776076699549697",
            "approval_group_status": "1",
            "approval_group_status_v2": 1,
            "topic": "因组织发展需要， 变更XXX 部门组织架构",
            "adjust_reason": "例如：因业务扩展需要， 现需增设 XXX 和 XXX 两个区域部门，便于上午拓展。 ",
            "effective_date": "2022-03-01",
            "created_by": "6974641477444060708",
            "draft_id": "6991776076699549697",
            "draft_status": "Edit",
            "department_changes": [
                "7044427347159741231 "
            ],
            "job_changes": [
                "7044427347159746085"
            ],
            "position_changes": [
                "7044427347159746085"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2ApprovalGroupsByProcessIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}