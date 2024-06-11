namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享个人名片消息
    /// </summary>
    public record ShareUserContent : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "share_user";

        /// <summary>
        /// 个人名片Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;
    }
}
