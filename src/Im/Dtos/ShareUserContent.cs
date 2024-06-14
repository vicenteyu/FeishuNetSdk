namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享个人名片消息
    /// </summary>
    public record ShareUserContent(string MessageType = "share_user") : MessageContent(MessageType)
    {
        /// <summary>
        /// 个人名片Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
