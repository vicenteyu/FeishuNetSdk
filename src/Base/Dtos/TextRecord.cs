namespace FeishuNetSdk.Base.Dtos;

//[JsonPolymorphic(TypeDiscriminatorPropertyName = "type",
//    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
//    IgnoreUnrecognizedTypeDiscriminators = true)]
//[JsonDerivedType(typeof(TextUrlRecord), typeDiscriminator: "url")]
//[JsonDerivedType(typeof(TextMentionRecord), typeDiscriminator: "mention")]
/// <summary>
/// 文本记录
/// </summary>
/// <param name="Link"></param>
/// <param name="Token"></param>
/// <param name="MentionType"></param>
/// <param name="MentionNotify"></param>
/// <param name="Name"></param>
/// <param name="Text"></param>
/// <param name="Type"></param>
public record TextRecord(
    [property: JsonPropertyName("link")] string? Link,
    [property: JsonPropertyName("token")] string? Token,
    [property: JsonPropertyName("mentionType")] string? MentionType,
    [property: JsonPropertyName("mentionNotify")] bool? MentionNotify,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("text")] string? Text,
    [property: JsonPropertyName("type")] string? Type) : IBitableRecord;
