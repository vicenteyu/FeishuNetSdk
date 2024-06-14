namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 语音消息
    /// </summary>
    /// <param name="FileKey">语音文件Key，可通过上传文件接口获取文件的 file_key。</param>
    public record AudioContent([property: JsonPropertyName("file_key")] string FileKey = "") : MessageContent("audio");
}
