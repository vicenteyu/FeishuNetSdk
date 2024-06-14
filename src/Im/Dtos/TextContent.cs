namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文本消息
    /// </summary>
    public record TextContent(string MessageType = "text") : MessageContent(MessageType)
    {
        /// <summary>
        /// 文本消息
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }
}
