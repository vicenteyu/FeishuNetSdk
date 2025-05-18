namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 超链接类型记录
/// </summary>
/// <param name="Link">链接</param>
/// <param name="Text">超链接中展示的文本</param>
public record UrlRecord(
    [property: JsonPropertyName("link")] string Link,
    [property: JsonPropertyName("text")] string Text) : IBitableRecord;