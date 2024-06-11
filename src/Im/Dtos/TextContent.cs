namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文本消息
    /// </summary>
    public record TextContent : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "text";

        /// <summary>
        /// 文本消息
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }
}
