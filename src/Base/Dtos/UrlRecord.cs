namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 超链接类型记录
/// </summary>
/// <param name="Link"></param>
/// <param name="Text"></param>
public record UrlRecord(
    [property: JsonPropertyName("link")] string Link,
    [property: JsonPropertyName("text")] string Text) : IBitableRecord;