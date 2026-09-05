// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="Test_VcBotMeetingActivityV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 会中事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Vc.Events;

/// <summary>
/// 测试 会中事件 事件体
/// <para>接口ID：7672664994766900471</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/supportEventsList/meeting_activity</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fsupportEventsList%2fmeeting_activity</para>
/// </summary>
[TestClass]
public class Test_VcBotMeetingActivityV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "vc.bot.meeting_activity_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "meeting_activity_items": [
            {
                "meeting": {
                    "id": "7628148899983674909",
                    "topic": "周会",
                    "meeting_no": "123456789",
                    "start_time": "1712345678",
                    "end_time": "1712349278",
                    "host_user": {
                        "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
                        "user_type": 1,
                        "user_role": 1,
                        "user_name": "张三"
                    }
                },
                "activity_event_type": "participant_joined",
                "participant_joined_items": [
                    {
                        "participant": {
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
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
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
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
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
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
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
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
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
                            "user_type": 1,
                            "user_role": 1,
                            "user_name": "张三"
                        },
                        "share_id": "share_abc_123",
                        "share_doc": {
                            "url": "https://example.feishu.cn/docx/xxx",
                            "title": "会议讨论稿"
                        },
                        "time": "1712345678000",
                        "start_reason": "share_started"
                    }
                ],
                "magic_share_ended_items": [
                    {
                        "operator": {
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
                            "user_type": 1,
                            "user_role": 1,
                            "user_name": "张三"
                        },
                        "share_id": "share_abc_123",
                        "time": "1712349200000"
                    }
                ],
                "document_context_changed_items": [
                    {
                        "operator": {
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
                            "user_type": 1,
                            "user_role": 1,
                            "user_name": "张三"
                        },
                        "share_id": "7359880116",
                        "share_doc": {
                            "url": "https://example.feishu.cn/docx/xxx",
                            "title": "会议讨论稿"
                        },
                        "time": "1717171234567",
                        "comment_focus": {
                            "comment_id": "7380000000000000000",
                            "focused": true
                        },
                        "section_location": {
                            "title": "项目进展",
                            "level": 1,
                            "parent_titles": [
                                "会议"
                            ]
                        },
                        "element_preview": {
                            "action": "open",
                            "element_type": "image",
                            "element_token": "element_xxx",
                            "block_id": "block_xxx"
                        }
                    }
                ],
                "countdown_items": [
                    {
                        "action": "SET",
                        "operator": {
                            "id": {
  "open_id": "ou_e31286c2456c474524768abcd295ca1b",
  "union_id": "on_4ceee576601af6e38fe40fc5b60c6ee2",
  "user_id": null
},
                            "user_type": 1,
                            "user_role": 1,
                            "user_name": "张三"
                        },
                        "end_time": "1712349200000",
                        "event_time": "1712348900000",
                        "need_play_audio_at_end": true,
                        "reminders_before_end_in_second": [
                            10
                        ],
                        "seq_id": "12345",
                        "countdown_set_time": "1712348600000",
                        "remain_minutes": 5
                    }
                ]
            }
        ]
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Vc.Events.VcBotMeetingActivityV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}