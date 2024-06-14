namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文件消息
    /// </summary>
    /// <param name="FileKey">文件Key，可通过上传文件接口获取文件的 file_key。</param>
    public record FileContent([property: JsonPropertyName("file_key")] string FileKey = "") : MessageContent("file");

}
