// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ReserveConfigsReserveScopeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询会议室预定限制 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 查询会议室预定限制 响应体
/// <para>接口ID：7152043170151333892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/reserve_scope</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve_config%2freserve_scope</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ReserveConfigsReserveScopeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "approve_config": {
            "approval_switch": 1,
            "approval_condition": 1,
            "meeting_duration": 3,
            "approvers": [
                {
                    "user_id": "ou_a27b0xxxc98f856"
                }
            ]
        },
        "time_config": {
            "if_cover_child_scope": true,
            "time_switch": 1,
            "days_in_advance": 30,
            "opening_hour": "27900",
            "start_time": "0",
            "end_time": "86400",
            "max_duration": 24
        },
        "reserve_scope_config": {
            "if_cover_child_scope": true,
            "allow_all_users": 0,
            "allow_users": [
                {
                    "user_id": "ou_a27bxxx8f856"
                }
            ],
            "allow_depts": [
                {
                    "department_id": "od-47d8b5xxxcc5f61a"
                }
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ReserveConfigsReserveScopeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}