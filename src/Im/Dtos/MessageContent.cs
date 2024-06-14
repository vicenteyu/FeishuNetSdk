namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// MessageContent
    /// </summary>
    /// <param name="MessageType">消息类型</param>
    public abstract record MessageContent(string MessageType) : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType { get; } = MessageType;
    }
}
