// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostVcV1ReservesApplyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 预约会议 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 预约会议 请求体
/// <para>接口ID：6960861158129008643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/apply</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fapply</para>
/// </summary>
[TestClass]
public class Test_PostVcV1ReservesApplyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "end_time": "1608888867",
    "owner_id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
    "meeting_settings": {
        "topic": "my meeting",
        "action_permissions": [
            {
                "permission": 1,
                "permission_checkers": [
                    {
                        "check_field": 1,
                        "check_mode": 1,
                        "check_list": [
                            "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
                        ]
                    }
                ]
            }
        ],
        "meeting_initial_type": 1,
        "meeting_connect": true,
        "call_setting": {
            "callee": {
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                "user_type": 1,
                "pstn_sip_info": {
                    "nickname": "dodo",
                    "main_address": "+86-02187654321"
                }
            }
        },
        "auto_record": true,
        "assign_host_list": [
            {
                "user_type": 1,
                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b"
            }
        ],
        "password": "971024"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Vc.PostVcV1ReservesApplyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}