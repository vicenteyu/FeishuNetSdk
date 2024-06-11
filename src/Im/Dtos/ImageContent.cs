namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 图片消息
    /// </summary>
    public record ImageContent : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "image";

        /// <summary>
        /// 其中image key需要通过上传图片接口取得
        /// </summary>
        [JsonPropertyName("image_key")]
        public string ImageKey { get; set; } = string.Empty;
    }
}
