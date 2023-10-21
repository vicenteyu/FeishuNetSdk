using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 回复用户在工单里的提问 请求体
/// <para>该接口用于回复用户提问结果至工单，需要工单仍处于进行中且未接入人工状态。仅支持自建应用。</para>
/// <para>接口ID：6955768699895988226</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/answer_user_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fanswer_user_query</para>
/// </summary>
public record PostHelpdeskV1TicketsByTicketIdAnswerUserQueryBodyDto
{
    /// <summary>
    /// <para>事件ID,可从订阅事件中提取</para>
    /// <para>必填：是</para>
    /// <para>示例值：abcd</para>
    /// </summary>
    [JsonProperty("event_id")]
    public string EventId { get; set; } = string.Empty;

    /// <summary>
    /// <para>faq结果列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("faqs")]
    public UserQueryFaqInfo[]? Faqs { get; set; }

    /// <summary>
    /// <para>faq结果列表</para>
    /// </summary>
    public record UserQueryFaqInfo
    {
        /// <summary>
        /// <para>faq服务台内唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：12345</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>faq匹配得分</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.9</para>
        /// </summary>
        [JsonProperty("score")]
        public float? Score { get; set; }
    }
}
