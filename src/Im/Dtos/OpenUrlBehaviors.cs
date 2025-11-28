namespace FeishuNetSdk.Im.Dtos;

/// <summary>
/// 跳转链接交互
/// </summary>
/// <param name="DefaultUrl">兜底跳转地址。</param>
/// <param name="AndroidUrl">Android 端的链接地址。可配置为 lark://msgcard/unsupported_action 声明当前端不允许跳转。</param>
/// <param name="IosUrl">iOS 端的链接地址。可配置为 lark://msgcard/unsupported_action 声明当前端不允许跳转。</param>
/// <param name="PcUrl">PC 端的链接地址。可配置为 lark://msgcard/unsupported_action 声明当前端不允许跳转。</param>
[JsonPolymorphic(TypeDiscriminatorPropertyName = FeishuNetSdkOptions.Discriminator.Type,
    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
    IgnoreUnrecognizedTypeDiscriminators = true)]
[JsonDerivedType(typeof(OpenUrlBehaviors), typeDiscriminator: "open_url")]
public record OpenUrlBehaviors([property: JsonPropertyName("default_url")] string? DefaultUrl = null,
    [property: JsonPropertyName("android_url")] string? AndroidUrl = null,
    [property: JsonPropertyName("ios_url")] string? IosUrl = null,
    [property: JsonPropertyName("pc_url")] string? PcUrl = null) : Behaviors("open_url");
