using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 获取工单消息详情 响应体
/// <para>该接口用于获取服务台工单消息详情。</para>
/// <para>接口ID：6955768699895840770</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket-message/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket-message%2flist</para>
/// </summary>
public record GetHelpdeskV1TicketsByTicketIdMessagesResponseDto
{
    /// <summary>
    /// <para>工单消息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("messages")]
    public TicketMessage[]? Messages { get; set; }

    /// <summary>
    /// <para>工单消息列表</para>
    /// </summary>
    public record TicketMessage
    {
        /// <summary>
        /// <para>工单消息ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6948728206392295444</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>chat消息ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6949088236610273307</para>
        /// </summary>
        [JsonProperty("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>消息类型；text：纯文本；post：富文本；image：图像；file：文件；media：视频</para>
        /// <para>必填：是</para>
        /// <para>示例值：text</para>
        /// </summary>
        [JsonProperty("message_type")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1617960686000</para>
        /// </summary>
        [JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// <para>内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"content\":\"进入人工服务。@李宁为你提供服务，开始聊起来吧~\",\"msg_type\":\"text\"}</para>
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户名</para>
        /// <para>必填：否</para>
        /// <para>示例值：李宁</para>
        /// </summary>
        [JsonProperty("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// <para>用户图片url</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/3e73cdce-54b0-4c6a-8226-b131fb2825dj~?image_size=72x72&cut_type=&quality=&format=image&sticker_format=.webp</para>
        /// </summary>
        [JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// <para>用户open ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_37019b7c830210acd88fdce886e25c71</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }

    /// <summary>
    /// <para>消息总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonProperty("total")]
    public int? Total { get; set; }
}
