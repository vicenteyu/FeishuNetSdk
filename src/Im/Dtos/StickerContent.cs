namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表情包消息
    /// </summary>
    public record StickerContent : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "sticker";

        /// <summary>
        /// 表情包文件Key，目前仅支持发送机器人收到的表情包，可通过接收消息事件的推送获取表情包 file_key。
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; } = string.Empty;
    }
}
