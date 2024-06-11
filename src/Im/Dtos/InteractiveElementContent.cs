namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片元素内容
    /// </summary>
    public record InteractiveElementContent : ElementsCard, IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "interactive";
    }
}
