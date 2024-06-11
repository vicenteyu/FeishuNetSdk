namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享群名片消息
    /// </summary>
    public record ShareChatContent : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "share_chat";

        /// <summary>
        /// 群名片Id
        /// </summary>
        [JsonPropertyName("share_chat_id")]
        public string ShareChatId { get; set; } = string.Empty;
    }
}
