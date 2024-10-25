// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HelpdeskTicketCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建工单 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk.Events;
/// <summary>
/// 创建工单 事件体
/// <para>可监听服务台的工单创建事件。需使用订阅接口订阅：[事件订阅](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/event/subscribe){使用示例}(url=/api/tools/api_explore/api_explore_config?project=helpdesk&amp;version=v1&amp;resource=ticket&amp;event=created)</para>
/// <para>接口ID：6955768699895545858</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fevents%2fcreated</para>
/// </summary>
public record HelpdeskTicketCreatedV1EventBodyDto() : EventBodyDto("helpdesk.ticket.created_v1")
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
    /// <para>服务台id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("helpdesk_id")]
    public string? HelpdeskId { get; set; }

    /// <summary>
    /// <para>用户id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("guest")]
    public TicketUserEvent? Guest { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record TicketUserEvent
    {
        /// <summary>
        /// <para>id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public UserIdSuffix? Id { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// <para>工单阶段：1. 机器人 2. 人工</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("stage")]
    public int? Stage { get; set; }

    /// <summary>
    /// <para>工单状态，1：已创建 2: 处理中 3: 排队中 4：待定 5：待用户响应 50: 被机器人关闭 51: 被客服关闭 52: 用户自己关闭</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>工单评分，1：不满意，2:一般，3:满意</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("score")]
    public int? Score { get; set; }

    /// <summary>
    /// <para>创建时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public int? CreatedAt { get; set; }

    /// <summary>
    /// <para>工单更新时间，没有值时为-1</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("updated_at")]
    public int? UpdatedAt { get; set; }

    /// <summary>
    /// <para>关单时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("closed_at")]
    public int? ClosedAt { get; set; }

    /// <summary>
    /// <para>工单渠道，描述：9：Open API 2：二维码 14：分享 13：搜索 其他数字：其他渠道</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("channel")]
    public int? Channel { get; set; }

    /// <summary>
    /// <para>工单是否解决 1:没解决 2:已解决</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("solve")]
    public int? Solve { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>**注意**：该事件不会返回该值，你可以获取 ticket_id 后调用[查询指定工单详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/get)接口查询自定义字段信息。</para>
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
    /// <para>oc_xxxxxxx</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }
}
