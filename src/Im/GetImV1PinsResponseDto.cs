using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群内 Pin 消息 响应体
/// <para>获取所在群内指定时间范围内的所有 Pin 消息。</para>
/// <para>接口ID：7138313270488891394</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2flist</para>
/// </summary>
public record GetImV1PinsResponseDto
{
    /// <summary>
    /// <para>Pin的操作信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Pin[]? Items { get; set; }

    /// <summary>
    /// <para>Pin的操作信息</para>
    /// </summary>
    public record Pin
    {
        /// <summary>
        /// <para>Pin的消息ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonProperty("message_id")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Pin消息所在的群聊ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>Pin的操作人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
        /// </summary>
        [JsonProperty("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>Pin的操作人ID类型。当Pin的操作人为用户时，为==open_id==；当Pin的操作人为机器人时，为==app_id==</para>
        /// <para>必填：否</para>
        /// <para>示例值：open_id</para>
        /// </summary>
        [JsonProperty("operator_id_type")]
        public string? OperatorIdType { get; set; }

        /// <summary>
        /// <para>Pin的创建时间（毫秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1615380573211</para>
        /// </summary>
        [JsonProperty("create_time")]
        public string? CreateTime { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：GxmvlNRvP0NdQZpa7yIqf_Lv_QuBwTQ8tXkX7w-irAghVD_TvuYd1aoJ1LQph86O-XImC4X9j9FhUPhXQDvtrQ==</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
