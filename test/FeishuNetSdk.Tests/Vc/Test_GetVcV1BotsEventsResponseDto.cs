// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-07-05
// ************************************************************************
// <copyright file="Test_GetVcV1BotsEventsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取会议事件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取会议事件 响应体
/// <para>接口ID：7657481714696588519</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/events</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fevents</para>
/// </summary>
[TestClass]
public class Test_GetVcV1BotsEventsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "events": [
            {
                "event_id": "evt_20240520143000_123456",
                "event_type": "meeting.created",
                "event_time": "2024-05-20T14:30:00+08:00",
                "payload": {
                    "meeting": {
                        "id": "7628148899983674909",
                        "topic": "周会",
                        "meeting_no": "123456789",
                        "start_time": "1712345678",
                        "end_time": "1712349278",
                        "host_user": {
                            "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                            "user_type": 1,
                            "user_role": 1,
                            "user_name": "张三"
                        }
                    },
                    "activity_event_type": "participant_joined",
                    "participant_joined_items": [
                        {
                            "participant": {
                                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                                "user_type": 1,
                                "user_role": 1,
                                "user_name": "张三"
                            },
                            "join_time": "1712345678000"
                        }
                    ],
                    "participant_left_items": [
                        {
                            "participant": {
                                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                                "user_type": 1,
                                "user_role": 1,
                                "user_name": "张三"
                            },
                            "leave_reason": 1,
                            "leave_time": "1712349200000"
                        }
                    ],
                    "transcript_received_items": [
                        {
                            "speaker": {
                                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                                "user_type": 1,
                                "user_role": 1,
                                "user_name": "张三"
                            },
                            "text": "大家好，今天的会议主题是……",
                            "language": "zh",
                            "start_time_ms": "1712345678000",
                            "end_time_ms": "1712345682000",
                            "sentence_id": "1001"
                        }
                    ],
                    "chat_received_items": [
                        {
                            "operator": {
                                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                                "user_type": 1,
                                "user_role": 1,
                                "user_name": "张三"
                            },
                            "message_id": "m_1001",
                            "message_type": 1,
                            "content": "你好",
                            "send_time": "1712345678000"
                        }
                    ],
                    "magic_share_started_items": [
                        {
                            "operator": {
                                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                                "user_type": 1,
                                "user_role": 1,
                                "user_name": "张三"
                            },
                            "share_id": "share_abc_123",
                            "share_doc": {
                                "url": "https://example.feishu.cn/docx/xxx",
                                "title": "会议讨论稿"
                            },
                            "time": "1712345678000"
                        }
                    ],
                    "magic_share_ended_items": [
                        {
                            "operator": {
                                "id": "ou_3ec3f6a28a0d08c45d895276e8e5e19b",
                                "user_type": 1,
                                "user_role": 1,
                                "user_name": "张三"
                            },
                            "share_id": "share_abc_123",
                            "time": "1712349200000"
                        }
                    ]
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1BotsEventsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}