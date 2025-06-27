// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="GetHelpdeskV1TicketsByTicketIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询指定工单详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 查询指定工单详情 响应体
/// <para>该接口用于获取单个服务台工单详情。仅支持自建应用。</para>
/// <para>接口ID：6955768699896070146</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fget</para>
/// </summary>
public record GetHelpdeskV1TicketsByTicketIdResponseDto
{
    /// <summary>
    /// <para>工单详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ticket")]
    public TicketV2? Ticket { get; set; }

    /// <summary>
    /// <para>工单详情</para>
    /// </summary>
    public record TicketV2
    {
        /// <summary>
        /// <para>工单ID</para>
        /// <para>[可以从工单列表里面取](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/list)</para>
        /// <para>[也可以订阅工单创建事件获取](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/events/created)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6626871355780366331</para>
        /// </summary>
        [JsonPropertyName("ticket_id")]
        public string TicketId { get; set; } = string.Empty;

        /// <summary>
        /// <para>服务台ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6626871355780366330</para>
        /// </summary>
        [JsonPropertyName("helpdesk_id")]
        public string? HelpdeskId { get; set; }

        /// <summary>
        /// <para>工单创建用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("guest")]
        public TicketUser? Guest { get; set; }

        /// <summary>
        /// <para>工单创建用户</para>
        /// </summary>
        public record TicketUser
        {
            /// <summary>
            /// <para>用户ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_37019b7c830210acd88fdce886e25c71</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>用户头像url</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://xxxx</para>
            /// </summary>
            [JsonPropertyName("avatar_url")]
            public string? AvatarUrl { get; set; }

            /// <summary>
            /// <para>用户名</para>
            /// <para>必填：否</para>
            /// <para>示例值：abc</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// <para>用户邮箱</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxxx@abc.com</para>
            /// </summary>
            [JsonPropertyName("email")]
            public string? Email { get; set; }

            /// <summary>
            /// <para>所在部门名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：用户部门名称(有权限才展示)</para>
            /// </summary>
            [JsonPropertyName("department")]
            public string? Department { get; set; }

            /// <summary>
            /// <para>城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：城市</para>
            /// </summary>
            [JsonPropertyName("city")]
            public string? City { get; set; }

            /// <summary>
            /// <para>国家代号(CountryCode)，参考：http://www.mamicode.com/info-detail-2186501.html</para>
            /// <para>必填：否</para>
            /// <para>示例值：国家</para>
            /// </summary>
            [JsonPropertyName("country")]
            public string? Country { get; set; }
        }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("comments")]
        public TicketV2Comments? Comments { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// </summary>
        public record TicketV2Comments
        {
            /// <summary>
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：备注内容</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>备注时间，单位毫秒</para>
            /// <para>必填：否</para>
            /// <para>示例值：1690970837624</para>
            /// </summary>
            [JsonPropertyName("created_at")]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>备注ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            /// <summary>
            /// <para>备注人头像</para>
            /// <para>必填：否</para>
            /// <para>示例值：备注人头像</para>
            /// </summary>
            [JsonPropertyName("user_avatar_url")]
            public string? UserAvatarUrl { get; set; }

            /// <summary>
            /// <para>备注人姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：备注人姓名</para>
            /// </summary>
            [JsonPropertyName("user_name")]
            public string? UserName { get; set; }

            /// <summary>
            /// <para>备注人ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7262656095919128578</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public long? UserId { get; set; }
        }

        /// <summary>
        /// <para>工单阶段：1. 机器人 2. 人工</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("ticket_type")]
        public int? TicketType { get; set; }

        /// <summary>
        /// <para>工单状态，1：已创建 2: 处理中 3: 排队中 4：待定 5：待用户响应 50: 被机器人关闭 51: 被客服关闭 52: 用户自己关闭</para>
        /// <para>必填：否</para>
        /// <para>示例值：50</para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>工单评分，1：不满意，2:一般，3:满意</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// <para>工单创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1616920429000</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>工单更新时间，没有值时为-1</para>
        /// <para>必填：否</para>
        /// <para>示例值：1616920429000</para>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>工单结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1616920429000</para>
        /// </summary>
        [JsonPropertyName("closed_at")]
        public long? ClosedAt { get; set; }

        /// <summary>
        /// <para>不满意原因</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("dissatisfaction_reason")]
        public I18n? DissatisfactionReason { get; set; }

        /// <summary>
        /// <para>不满意原因</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：答案看不懂</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：I don't understand</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }

            /// <summary>
            /// <para>日文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：回答が複雑すぎる</para>
            /// </summary>
            [JsonPropertyName("ja_jp")]
            public string? JaJp { get; set; }
        }

        /// <summary>
        /// <para>工单客服</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("agents")]
        public TicketUser[]? Agents { get; set; }

        /// <summary>
        /// <para>工单渠道，描述：</para>
        /// <para>9：Open API 2：二维码 14：分享 13：搜索 其他数字：其他渠道</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("channel")]
        public int? Channel { get; set; }

        /// <summary>
        /// <para>工单是否解决 1:没解决 2:已解决</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("solve")]
        public int? Solve { get; set; }

        /// <summary>
        /// <para>关单用户ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("closed_by")]
        public TicketUser? ClosedBy { get; set; }

        /// <summary>
        /// <para>工单协作者</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("collaborators")]
        public TicketUser[]? Collaborators { get; set; }

        /// <summary>
        /// <para>自定义字段列表，没有值时不设置</para>
        /// <para>下拉菜单的value对应工单字段里面的children.display_name</para>
        /// <para>[获取全部工单自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket_customized_field/list-ticket-customized-fields)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("customized_fields")]
        public CustomizedFieldDisplayItem[]? CustomizedFields { get; set; }

        /// <summary>
        /// <para>自定义字段列表，没有值时不设置</para>
        /// <para>下拉菜单的value对应工单字段里面的children.display_name</para>
        /// <para>[获取全部工单自定义字段](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket_customized_field/list-ticket-customized-fields)</para>
        /// </summary>
        public record CustomizedFieldDisplayItem
        {
            /// <summary>
            /// <para>自定义字段ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：123</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>自定义字段值</para>
            /// <para>必填：否</para>
            /// <para>示例值：value</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>键名</para>
            /// <para>必填：否</para>
            /// <para>示例值：key</para>
            /// </summary>
            [JsonPropertyName("key_name")]
            public string? KeyName { get; set; }

            /// <summary>
            /// <para>展示名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：display name</para>
            /// </summary>
            [JsonPropertyName("display_name")]
            public string? DisplayName { get; set; }

            /// <summary>
            /// <para>展示位置</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("position")]
            public int? Position { get; set; }

            /// <summary>
            /// <para>是否必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("required")]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>是否可修改</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("editable")]
            public bool? Editable { get; set; }
        }

        /// <summary>
        /// <para>客服服务时长，客服最后一次回复时间距离客服进入时间间隔，单位分钟</para>
        /// <para>必填：否</para>
        /// <para>示例值：42624.95</para>
        /// </summary>
        [JsonPropertyName("agent_service_duration")]
        public float? AgentServiceDuration { get; set; }

        /// <summary>
        /// <para>客服首次回复时间距离客服进入时间的间隔(秒)</para>
        /// <para>必填：否</para>
        /// <para>示例值：123869</para>
        /// </summary>
        [JsonPropertyName("agent_first_response_duration")]
        public int? AgentFirstResponseDuration { get; set; }

        /// <summary>
        /// <para>机器人服务时间：客服进入时间距离工单创建时间的间隔，单位秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("bot_service_duration")]
        public int? BotServiceDuration { get; set; }

        /// <summary>
        /// <para>客服解决时长，从首位客服接入服务到工单关闭的用时，单位秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：66</para>
        /// </summary>
        [JsonPropertyName("agent_resolution_time")]
        public int? AgentResolutionTime { get; set; }

        /// <summary>
        /// <para>工单实际处理时长，处理时长=解决时长-工单待定时长（将工单状态修改为待定后的时间），单位秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：68</para>
        /// </summary>
        [JsonPropertyName("actual_processing_time")]
        public int? ActualProcessingTime { get; set; }

        /// <summary>
        /// <para>客服进入时间，单位毫秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：1636444596000</para>
        /// </summary>
        [JsonPropertyName("agent_entry_time")]
        public long? AgentEntryTime { get; set; }

        /// <summary>
        /// <para>客服首次回复时间，单位毫秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：1636444696000</para>
        /// </summary>
        [JsonPropertyName("agent_first_response_time")]
        public long? AgentFirstResponseTime { get; set; }

        /// <summary>
        /// <para>客服最后回复时间，单位毫秒</para>
        /// <para>必填：否</para>
        /// <para>示例值：1636444796000</para>
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
        /// <para>工单标签（仅工单含有工单标签会返回）</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tags")]
        public TicketTag[]? Tags { get; set; }

        /// <summary>
        /// <para>工单标签（仅工单含有工单标签会返回）</para>
        /// </summary>
        public record TicketTag
        {
            /// <summary>
            /// <para>标签 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值："7474857595946745884"</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>标签</para>
            /// <para>必填：否</para>
            /// <para>示例值：标签名称</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }
}
