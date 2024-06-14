namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 图片消息
    /// </summary>
    /// <param name="ImageKey">ImageKey需要先通过上传图片接口取得</param>
    public record ImageContent([property: JsonPropertyName("image_key")] string ImageKey = "") : MessageContent("image");
}
