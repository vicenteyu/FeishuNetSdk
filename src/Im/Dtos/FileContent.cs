namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文件消息
    /// </summary>
    public record FileContent : IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        public string MessageType => "file";

        /// <summary>
        /// 文件Key，可通过上传文件接口获取文件的 file_key。
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; } = string.Empty;
    }
}
