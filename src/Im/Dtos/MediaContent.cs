namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 视频消息
    /// </summary>
    public record MediaContent(string MessageType = "media") : MessageContent(MessageType)
    {
        /// <summary>
        /// 视频文件Key，可通过上传文件接口获取文件的 file_key。
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; } = string.Empty;

        /// <summary>
        /// 视频封面图片Key，可通过上传图片接口获取图片的image_key。
        /// </summary>
        [JsonPropertyName("image_key")]
        public string ImageKey { get; set; } = string.Empty;
    }
}
