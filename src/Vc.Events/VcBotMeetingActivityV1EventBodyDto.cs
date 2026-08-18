// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="VcBotMeetingActivityV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会中事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 会中事件 事件体
/// <para>当会议中发生参会人入会、离会等活动时，系统会向订阅方推送此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=bot&amp;event=meeting_activity)</para>
/// <para>接口ID：7672664994766900471</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/supportEventsList/meeting_activity</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fsupportEventsList%2fmeeting_activity</para>
/// </summary>
public record VcBotMeetingActivityV1EventBodyDto() : EventBodyDto("vc.bot.meeting_activity_v1")
{
    /// <summary>
    /// 
    /// </summary>
    public record MeetingAgentEventUser
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>用户类型</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`1` ～ `9`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_type")]
        public int? UserType { get; set; }

        /// <summary>
        /// <para>用户角色</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 取值范围：`0` ～ `3`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_role")]
        public int? UserRole { get; set; }

        /// <summary>
        /// <para>用户名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_name")]
        public string? UserName { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public record ShareDocSuffix
    {
        /// <summary>
        /// <para>文档 URL</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>文档标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }

    /// <summary>
    /// <para>会中事件</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `1000`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("meeting_activity_items")]
    public MeetingActivityItem[]? MeetingActivityItems { get; set; }

    /// <summary>
    /// 
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
        /// 
        /// </summary>
        public record MeetingAgentEventMeeting
        {
            /// <summary>
            /// <para>会议ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>会议主题</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("topic")]
            public string? Topic { get; set; }

            /// <summary>
            /// <para>9位会议号</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("meeting_no")]
            public string? MeetingNo { get; set; }

            /// <summary>
            /// <para>会议开始时间（unix时间，单位sec）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>会议结束时间（unix时间，单位sec）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }

            /// <summary>
            /// <para>会议主持人</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("host_user")]
            public MeetingAgentEventUser? HostUser { get; set; }
        }

        /// <summary>
        /// <para>会中活动子类型；取值 participant_joined / participant_left / transcript_received / chat_received / magic_share_started / magic_share_ended</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("activity_event_type")]
        public string? ActivityEventType { get; set; }

        /// <summary>
        /// <para>参会人入会内容（activity_event_type = participant_joined 时填充）</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `100`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("participant_joined_items")]
        public ParticipantJoinedItem[]? ParticipantJoinedItems { get; set; }

        /// <summary>
        /// 
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
            /// <para>入会时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("join_time")]
            public string? JoinTime { get; set; }
        }

        /// <summary>
        /// <para>参会人离会内容（activity_event_type = participant_left 时填充）</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `100`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("participant_left_items")]
        public ParticipantLeftItem[]? ParticipantLeftItems { get; set; }

        /// <summary>
        /// 
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
            /// <para>离会原因</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 取值范围：`0` ～ `3`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leave_reason")]
            public int? LeaveReason { get; set; }

            /// <summary>
            /// <para>离会时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("leave_time")]
            public string? LeaveTime { get; set; }
        }

        /// <summary>
        /// <para>字幕内容（activity_event_type = transcript_received 时填充）</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `50`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("transcript_received_items")]
        public TranscriptItem[]? TranscriptReceivedItems { get; set; }

        /// <summary>
        /// 
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
            /// <para>字幕文本</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text")]
            public string? Text { get; set; }

            /// <summary>
            /// <para>语言类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("language")]
            public string? Language { get; set; }

            /// <summary>
            /// <para>句子开始时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("start_time_ms")]
            public string? StartTimeMs { get; set; }

            /// <summary>
            /// <para>句子结束时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("end_time_ms")]
            public string? EndTimeMs { get; set; }

            /// <summary>
            /// <para>句子 ID（用于去重和排序）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("sentence_id")]
            public string? SentenceId { get; set; }
        }

        /// <summary>
        /// <para>聊天消息内容（activity_event_type = chat_received 时填充）</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `30`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("chat_received_items")]
        public ChatMessageItem[]? ChatReceivedItems { get; set; }

        /// <summary>
        /// 
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
            /// <para>消息 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("message_id")]
            public string? MessageId { get; set; }

            /// <summary>
            /// <para>消息类型</para>
            /// <para>**数据校验规则**：</para>
            /// <para>- 取值范围：`0` ～ `4`</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("message_type")]
            public int? MessageType { get; set; }

            /// <summary>
            /// <para>消息内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>发送时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("send_time")]
            public string? SendTime { get; set; }
        }

        /// <summary>
        /// <para>妙享开始内容（activity_event_type = magic_share_started 时填充）</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("magic_share_started_items")]
        public MagicShareStartedItem[]? MagicShareStartedItems { get; set; }

        /// <summary>
        /// 
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
            /// <para>共享会话 ID</para>
            /// <para>必填：否</para>
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
            /// <para>妙享开始时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }
        }

        /// <summary>
        /// <para>妙享结束内容（activity_event_type = magic_share_ended 时填充）</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("magic_share_ended_items")]
        public MagicShareEndedItem[]? MagicShareEndedItems { get; set; }

        /// <summary>
        /// 
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
            /// <para>共享会话 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("share_id")]
            public string? ShareId { get; set; }

            /// <summary>
            /// <para>妙享结束时间（毫秒级时间戳）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }
        }

        /// <summary>
        /// <para>文档上下文变化内容（activity_event_type = document_context_changed 时返回），单条记录包含评论聚焦、章节定位或元素预览中的一种变化</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`1` ～ `1`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("document_context_changed_items")]
        public DocumentContextChangedItem[]? DocumentContextChangedItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record DocumentContextChangedItem
        {
            /// <summary>
            /// <para>触发文档上下文变化的操作人，无法识别时不返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("operator")]
            public MeetingAgentEventUser? Operator { get; set; }

            /// <summary>
            /// <para>共享会话 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("share_id")]
            public string? ShareId { get; set; }

            /// <summary>
            /// <para>当前共享文档信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("share_doc")]
            public ShareDocSuffix? ShareDoc { get; set; }

            /// <summary>
            /// <para>事件发生时间，十进制毫秒级时间戳字符串</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("time")]
            public string? Time { get; set; }

            /// <summary>
            /// <para>评论聚焦变化，仅评论聚焦或取消聚焦时返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("comment_focus")]
            public CommentFocusSuffix? CommentFocus { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record CommentFocusSuffix
            {
                /// <summary>
                /// <para>评论 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("comment_id")]
                public string? CommentId { get; set; }

                /// <summary>
                /// <para>是否聚焦该评论，true 表示聚焦，false 表示取消聚焦</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("focused")]
                public bool? Focused { get; set; }
            }

            /// <summary>
            /// <para>章节位置变化，仅章节定位变化时返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("section_location")]
            public SectionLocationSuffix? SectionLocation { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record SectionLocationSuffix
            {
                /// <summary>
                /// <para>当前章节标题</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>当前章节层级</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 取值范围：`1` ～ `10000`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("level")]
                public int? Level { get; set; }

                /// <summary>
                /// <para>父级章节标题列表</para>
                /// <para>**数据校验规则**：</para>
                /// <para>- 长度范围：`1` ～ `1`</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("parent_titles")]
                public string[]? ParentTitles { get; set; }
            }

            /// <summary>
            /// <para>元素预览变化，仅图片或白板预览变化时返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("element_preview")]
            public ElementPreviewSuffix? ElementPreview { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public record ElementPreviewSuffix
            {
                /// <summary>
                /// <para>元素预览动作</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("action")]
                public string? Action { get; set; }

                /// <summary>
                /// <para>预览元素类型</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("element_type")]
                public string? ElementType { get; set; }

                /// <summary>
                /// <para>预览元素 Token</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("element_token")]
                public string? ElementToken { get; set; }

                /// <summary>
                /// <para>元素所在的文档 Block ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("block_id")]
                public string? BlockId { get; set; }
            }
        }
    }
}
