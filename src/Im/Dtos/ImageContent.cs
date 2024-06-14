namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 图片消息
    /// </summary>
    public record ImageContent(string MessageType = "image") : MessageContent(MessageType)
    {
        /// <summary>
        /// 其中image key需要通过上传图片接口取得
        /// </summary>
        [JsonPropertyName("image_key")]
        public string ImageKey { get; set; } = string.Empty;
    }
}
