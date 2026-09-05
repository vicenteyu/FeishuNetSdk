// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-05
//
// Last Modified By : yxr
// Last Modified On : 2026-09-05
// ************************************************************************
// <copyright file="GetVcV1BotsEventsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取会议事件列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取会议事件列表 响应体
/// <para>获取会议中的事件列表，包括参会人加入或离开、发言、聊天、共享等事件。调用前请根据鉴权身份完成准备：使用 user_access_token 时，授权用户需已在目标会议中，并通过[获取用户活跃会议列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/user_active_meeting)获取 meeting_id；使用 tenant_access_token 时，应用 Bot 需先通过[加入会议](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/join)接口进入目标会议，并使用入会接口返回的 meeting_id。</para>
/// <para>接口ID：7657481714696588519</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/events</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fevents</para>
/// </summary>
public record GetVcV1BotsEventsResponseDto : IPageableResponse<GetVcV1BotsEventsResponseDto.Event>
{
    /// <summary>
    /// <para>会议事件列表，包含会议生命周期内的所有关键操作记录。</para>
    /// <para>必填：否</para>
    /// </summary>
    public Event[]? Items => Events;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>会议事件列表，包含会议生命周期内的所有关键操作记录。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("events")]
    public Event[]? Events { get; set; }

    /// <summary>
    /// <para>会议事件列表，包含会议生命周期内的所有关键操作记录。</para>
    /// </summary>
    public record Event
    {
        /// <summary>
        /// <para>事件唯一标识，用于幂等校验和事件追踪。可通过事件创建接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：evt_20240520143000_123456</para>
        /// </summary>
        [JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// <para>事件类型，用于区分不同业务场景的事件，如会议创建、参会人变更、会议结束等</para>
        /// <para>必填：否</para>
        /// <para>示例值：meeting.created</para>
        /// </summary>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// <para>事件发生时间，RFC 3339 格式的日期时间字符串，例如 2024-05-20T14:30:00+08:00。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-05-20T14:30:00+08:00</para>
        /// </summary>
        [JsonPropertyName("event_time")]
        public string? EventTime { get; set; }

        /// <summary>
        /// <para>事件负载，包含与事件类型对应的业务数据，采用 JSON 格式序列化后的字符串</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("payload")]
        public MeetingActivityItem? Payload { get; set; }

        /// <summary>
        /// <para>事件负载，包含与事件类型对应的业务数据，采用 JSON 格式序列化后的字符串</para>
        /// </summary>
        public record MeetingActivityItem
        {
            /// <summary>
            /// <para>会议数据</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("meeting")]
            public MeetingAgentEventMeeting? Meeting { get; set; }

            /// <summary>
            /// <para>会议数据</para>
            /// </summary>
            public record MeetingAgentEventMeeting
            {
                /// <summary>
                /// <para>会议ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7628148899983674909</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>会议主题</para>
                /// <para>必填：否</para>
                /// <para>示例值：周会</para>
                /// </summary>
                [JsonPropertyName("topic")]
                public string? Topic { get; set; }

                /// <summary>
                /// <para>9位会议号</para>
                /// <para>必填：否</para>
                /// <para>示例值：123456789</para>
                /// </summary>
                [JsonPropertyName("meeting_no")]
                public string? MeetingNo { get; set; }

                /// <summary>
                /// <para>会议开始时间（unix时间，单位sec）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712345678</para>
                /// </summary>
                [JsonPropertyName("start_time")]
                public string? StartTime { get; set; }

                /// <summary>
                /// <para>会议结束时间（unix时间，单位sec）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712349278</para>
                /// </summary>
                [JsonPropertyName("end_time")]
                public string? EndTime { get; set; }

                /// <summary>
                /// <para>会议主持人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("host_user")]
                public MeetingAgentEventUser? HostUser { get; set; }

                /// <summary>
                /// <para>会议主持人</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }
            }

            /// <summary>
            /// <para>会中活动子类型；取值 participant_joined / participant_left / transcript_received / chat_received / magic_share_started / magic_share_ended</para>
            /// <para>必填：否</para>
            /// <para>示例值：participant_joined</para>
            /// </summary>
            [JsonPropertyName("activity_event_type")]
            public string? ActivityEventType { get; set; }

            /// <summary>
            /// <para>参会人入会内容（activity_event_type = participant_joined 时填充）</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("participant_joined_items")]
            public ParticipantJoinedItem[]? ParticipantJoinedItems { get; set; }

            /// <summary>
            /// <para>参会人入会内容（activity_event_type = participant_joined 时填充）</para>
            /// </summary>
            public record ParticipantJoinedItem
            {
                /// <summary>
                /// <para>入会的参会人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("participant")]
                public MeetingAgentEventUser? Participant { get; set; }

                /// <summary>
                /// <para>入会的参会人</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }

                /// <summary>
                /// <para>入会时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712345678000</para>
                /// </summary>
                [JsonPropertyName("join_time")]
                public string? JoinTime { get; set; }
            }

            /// <summary>
            /// <para>参会人离会内容（activity_event_type = participant_left 时填充）</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("participant_left_items")]
            public ParticipantLeftItem[]? ParticipantLeftItems { get; set; }

            /// <summary>
            /// <para>参会人离会内容（activity_event_type = participant_left 时填充）</para>
            /// </summary>
            public record ParticipantLeftItem
            {
                /// <summary>
                /// <para>离会的参会人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("participant")]
                public MeetingAgentEventUser? Participant { get; set; }

                /// <summary>
                /// <para>离会的参会人</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }

                /// <summary>
                /// <para>离会原因</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：3</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("leave_reason")]
                public int? LeaveReason { get; set; }

                /// <summary>
                /// <para>离会时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712349200000</para>
                /// </summary>
                [JsonPropertyName("leave_time")]
                public string? LeaveTime { get; set; }
            }

            /// <summary>
            /// <para>字幕内容（activity_event_type = transcript_received 时填充）</para>
            /// <para>必填：否</para>
            /// <para>最大长度：50</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("transcript_received_items")]
            public TranscriptItem[]? TranscriptReceivedItems { get; set; }

            /// <summary>
            /// <para>字幕内容（activity_event_type = transcript_received 时填充）</para>
            /// </summary>
            public record TranscriptItem
            {
                /// <summary>
                /// <para>发言人</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("speaker")]
                public MeetingAgentEventUser? Speaker { get; set; }

                /// <summary>
                /// <para>发言人</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }

                /// <summary>
                /// <para>字幕文本</para>
                /// <para>必填：否</para>
                /// <para>示例值：大家好，今天的会议主题是……</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// <para>语言类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：zh</para>
                /// </summary>
                [JsonPropertyName("language")]
                public string? Language { get; set; }

                /// <summary>
                /// <para>句子开始时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712345678000</para>
                /// </summary>
                [JsonPropertyName("start_time_ms")]
                public string? StartTimeMs { get; set; }

                /// <summary>
                /// <para>句子结束时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712345682000</para>
                /// </summary>
                [JsonPropertyName("end_time_ms")]
                public string? EndTimeMs { get; set; }

                /// <summary>
                /// <para>句子 ID（用于去重和排序）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1001</para>
                /// </summary>
                [JsonPropertyName("sentence_id")]
                public string? SentenceId { get; set; }
            }

            /// <summary>
            /// <para>聊天消息内容（activity_event_type = chat_received 时填充）</para>
            /// <para>必填：否</para>
            /// <para>最大长度：30</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("chat_received_items")]
            public ChatMessageItem[]? ChatReceivedItems { get; set; }

            /// <summary>
            /// <para>聊天消息内容（activity_event_type = chat_received 时填充）</para>
            /// </summary>
            public record ChatMessageItem
            {
                /// <summary>
                /// <para>发送者</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public MeetingAgentEventUser? Operator { get; set; }

                /// <summary>
                /// <para>发送者</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }

                /// <summary>
                /// <para>消息 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：m_1001</para>
                /// </summary>
                [JsonPropertyName("message_id")]
                public string? MessageId { get; set; }

                /// <summary>
                /// <para>消息类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>最大值：4</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("message_type")]
                public int? MessageType { get; set; }

                /// <summary>
                /// <para>消息内容</para>
                /// <para>必填：否</para>
                /// <para>示例值：你好</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>发送时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712345678000</para>
                /// </summary>
                [JsonPropertyName("send_time")]
                public string? SendTime { get; set; }
            }

            /// <summary>
            /// <para>妙享开始内容（activity_event_type = magic_share_started 时填充）</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("magic_share_started_items")]
            public MagicShareStartedItem[]? MagicShareStartedItems { get; set; }

            /// <summary>
            /// <para>妙享开始内容（activity_event_type = magic_share_started 时填充）</para>
            /// </summary>
            public record MagicShareStartedItem
            {
                /// <summary>
                /// <para>发起妙享的操作者</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public MeetingAgentEventUser? Operator { get; set; }

                /// <summary>
                /// <para>发起妙享的操作者</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }

                /// <summary>
                /// <para>共享会话 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：share_abc_123</para>
                /// </summary>
                [JsonPropertyName("share_id")]
                public string? ShareId { get; set; }

                /// <summary>
                /// <para>共享文档信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("share_doc")]
                public ShareDocSuffix? ShareDoc { get; set; }

                /// <summary>
                /// <para>共享文档信息</para>
                /// </summary>
                public record ShareDocSuffix
                {
                    /// <summary>
                    /// <para>文档 URL</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：https://example.feishu.cn/docx/xxx</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string? Url { get; set; }

                    /// <summary>
                    /// <para>文档标题</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：会议讨论稿</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }
                }

                /// <summary>
                /// <para>妙享开始时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712345678000</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }
            }

            /// <summary>
            /// <para>妙享结束内容（activity_event_type = magic_share_ended 时填充）</para>
            /// <para>必填：否</para>
            /// <para>最大长度：1</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("magic_share_ended_items")]
            public MagicShareEndedItem[]? MagicShareEndedItems { get; set; }

            /// <summary>
            /// <para>妙享结束内容（activity_event_type = magic_share_ended 时填充）</para>
            /// </summary>
            public record MagicShareEndedItem
            {
                /// <summary>
                /// <para>结束妙享的操作者</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("operator")]
                public MeetingAgentEventUser? Operator { get; set; }

                /// <summary>
                /// <para>结束妙享的操作者</para>
                /// </summary>
                public record MeetingAgentEventUser
                {
                    /// <summary>
                    /// <para>用户 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：ou_3ec3f6a28a0d08c45d895276e8e5e19b</para>
                    /// </summary>
                    [JsonPropertyName("id")]
                    public string? Id { get; set; }

                    /// <summary>
                    /// <para>用户类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：9</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("user_type")]
                    public int? UserType { get; set; }

                    /// <summary>
                    /// <para>用户角色</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>最大值：3</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("user_role")]
                    public int? UserRole { get; set; }

                    /// <summary>
                    /// <para>用户名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：张三</para>
                    /// </summary>
                    [JsonPropertyName("user_name")]
                    public string? UserName { get; set; }
                }

                /// <summary>
                /// <para>共享会话 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：share_abc_123</para>
                /// </summary>
                [JsonPropertyName("share_id")]
                public string? ShareId { get; set; }

                /// <summary>
                /// <para>妙享结束时间（毫秒级时间戳）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1712349200000</para>
                /// </summary>
                [JsonPropertyName("time")]
                public string? Time { get; set; }
            }
        }
    }
}
