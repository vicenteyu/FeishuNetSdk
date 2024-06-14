﻿namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文件消息
    /// </summary>
    public record FileContent(string MessageType = "file") : MessageContent(MessageType)
    {
        /// <summary>
        /// 文件Key，可通过上传文件接口获取文件的 file_key。
        /// </summary>
        [JsonPropertyName("file_key")]
        public string FileKey { get; set; } = string.Empty;
    }
}
