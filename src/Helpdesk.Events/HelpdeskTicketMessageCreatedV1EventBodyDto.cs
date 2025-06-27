// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HelpdeskTicketMessageCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>工单消息事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk.Events;
/// <summary>
/// 工单消息事件 事件体
/// <para>该消息事件属于工单消息事件。需使用订阅接口订阅：[事件订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/event/subscribe)。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=helpdesk&amp;version=v1&amp;resource=ticket_message&amp;event=created)</para>
/// <para>接口ID：6955768699895627778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket_message%2fevents%2fcreated</para>
/// </summary>
public record HelpdeskTicketMessageCreatedV1EventBodyDto() : EventBodyDto("helpdesk.ticket_message.created_v1")
{
    /// <summary>
    /// <para>ticket message id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ticket_message_id")]
    public string? TicketMessageId { get; set; }

    /// <summary>
    /// <para>open message id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>
    /// <para>message type, text is the only supported type</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string? MsgType { get; set; }

    /// <summary>
    /// <para>position of the message</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("position")]
    public string? Position { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sender_id")]
    public UserIdSuffix? SenderId { get; set; }

    /// <summary>
    /// <para>sender type, 1 for bot, 2 for guest, 3 for agent</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sender_type")]
    public int? SenderType { get; set; }

    /// <summary>
    /// <para>message content</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// <para>ticket related information</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ticket")]
    public TicketSuffix? Ticket { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record TicketSuffix
    {
        /// <summary>
        /// <para>工单ID</para>
        /// <para>[可以从工单列表里面取](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/list)</para>
        /// <para>[也可以订阅工单创建事件获取](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/events/created)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("comments")]
        public CommentsSuffix? Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record CommentsSuffix
        {
            /// <summary>
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>备注时间，单位毫秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("created_at")]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>备注ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            /// <summary>
            /// <para>备注人头像</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_avatar_url")]
            public string? UserAvatarUrl { get; set; }

            /// <summary>
            /// <para>备注人姓名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_name")]
            public string? UserName { get; set; }

            /// <summary>
            /// <para>备注人ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>工单阶段：1. 机器人 2. 人工</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("ticket_type")]
        public int? TicketType { get; set; }

        /// <summary>
        /// <para>工单状态，1：已创建 2: 处理中 3: 排队中 4：待定 5：待用户响应 50: 被机器人关闭 51: 被客服关闭 52: 用户自己关闭</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>不满意原因</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dissatisfaction_reason")]
        public I18nLanguage<string>? DissatisfactionReason { get; set; }

        /// <summary>
        /// <para>自定义字段列表，没有值时不设置</para>
        /// <para>下拉菜单的value对应工单字段里面的children.display_name</para>
        /// <para>[获取全部工单自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket_customized_field/list-ticket-customized-fields)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("customized_fields")]
        public CustomizedFieldDisplayItem[]? CustomizedFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record CustomizedFieldDisplayItem
        {
            /// <summary>
            /// <para>自定义字段ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>键名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("key_name")]
            public string? KeyName { get; set; }

            /// <summary>
            /// <para>展示名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string? DisplayName { get; set; }

            /// <summary>
            /// <para>展示位置</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("position")]
            public int? Position { get; set; }

            /// <summary>
            /// <para>是否必填</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("required")]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>是否可修改</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("editable")]
            public bool? Editable { get; set; }
        }

        /// <summary>
        /// <para>客服服务时长，客服最后一次回复时间距离客服进入时间间隔，单位分钟</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_service_duration")]
        public float? AgentServiceDuration { get; set; }

        /// <summary>
        /// <para>客服首次回复时间距离客服进入时间的间隔(秒)</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_first_response_duration")]
        public int? AgentFirstResponseDuration { get; set; }

        /// <summary>
        /// <para>机器人服务时间：客服进入时间距离工单创建时间的间隔，单位秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bot_service_duration")]
        public int? BotServiceDuration { get; set; }

        /// <summary>
        /// <para>客服解决时长，关单时间距离客服进入时间的间隔，单位秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_resolution_time")]
        public int? AgentResolutionTime { get; set; }

        /// <summary>
        /// <para>工单实际处理时间：从客服进入到关单，单位秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("actual_processing_time")]
        public int? ActualProcessingTime { get; set; }

        /// <summary>
        /// <para>客服进入时间，单位毫秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_entry_time")]
        public long? AgentEntryTime { get; set; }

        /// <summary>
        /// <para>客服首次回复时间，单位毫秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_first_response_time")]
        public long? AgentFirstResponseTime { get; set; }

        /// <summary>
        /// <para>客服最后回复时间，单位毫秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_last_response_time")]
        public long? AgentLastResponseTime { get; set; }

        /// <summary>
        /// <para>主责客服</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agent_owner")]
        public TicketUser? AgentOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record TicketUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户头像url</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户邮箱</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>所在部门名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("city")]
            public string? City { get; set; }

            /// <summary>
            /// <para>国家代号(CountryCode)，参考：http://www.mamicode.com/info-detail-2186501.html</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("country")]
            public string? Country { get; set; }
        }
    }

    /// <summary>
    /// <para>event id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("event_id")]
    public string? EventId { get; set; }

    /// <summary>
    /// <para>chat id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    /// <summary>
    /// <para>message content</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public TicketMessageContent? Content { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record TicketMessageContent
    {
        /// <summary>
        /// <para>内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>消息类型；text：纯文本；post：富文本；image：图片</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string? MsgType { get; set; }

        /// <summary>
        /// <para>图片ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("image_keys")]
        public string[]? ImageKeys { get; set; }

        /// <summary>
        /// <para>图片ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("image_key")]
        public string? ImageKey { get; set; }
    }
}
