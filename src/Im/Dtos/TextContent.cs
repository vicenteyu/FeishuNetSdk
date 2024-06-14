namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 文本消息
    /// </summary>
    /// <param name="Text">文本消息</param>
    public record TextContent([property: JsonPropertyName("text")] string Text = "") : MessageContent("text");

}
