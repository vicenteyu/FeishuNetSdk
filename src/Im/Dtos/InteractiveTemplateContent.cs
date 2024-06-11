namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 卡片模板内容
    /// </summary>
    public record InteractiveTemplateContent : TemplateCard, IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "interactive";
    }
}
