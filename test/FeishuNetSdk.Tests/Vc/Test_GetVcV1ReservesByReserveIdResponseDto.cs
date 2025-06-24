// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetVcV1ReservesByReserveIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取预约 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取预约 响应体
/// <para>接口ID：6921909217674936347</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/reserve/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2freserve%2fget</para>
/// </summary>
[TestClass]
public class Test_GetVcV1ReservesByReserveIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "reserve": {
            "id": "6911188411934973028",
            "meeting_no": "112000358",
            "password": "971024",
            "url": "https://vc.feishu.cn/j/337736498",
            "app_link": "https://applink.feishu.cn/client/videochat/open?source=openplatform&action=join&idtype=reservationid&id={?}&preview={?}&mic={?}&speaker={?}&camera={?}",
            "live_link": "https://meetings.feishu.cn/s/1gub381l4gglv",
            "end_time": "1608883322",
            "expire_status": 0,
            "reserve_user_id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
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
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1ReservesByReserveIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}