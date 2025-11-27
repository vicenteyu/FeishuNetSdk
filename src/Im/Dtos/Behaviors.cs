namespace FeishuNetSdk.Im.Dtos;

/// <summary>
/// 行为基类
/// </summary>
/// <param name="Type"></param>
[JsonPolymorphic(TypeDiscriminatorPropertyName = FeishuNetSdkOptions.Discriminator.Type,
    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
    IgnoreUnrecognizedTypeDiscriminators = true)]
[JsonDerivedType(typeof(CallbackBehaviors), typeDiscriminator: "callback")]
[JsonDerivedType(typeof(OpenUrlBehaviors), typeDiscriminator: "open_url")]
[JsonDerivedType(typeof(FormActionBehaviors), typeDiscriminator: "form_action")]
public abstract record Behaviors(string Type = "")
{
    /// <summary>
    /// 行为类型
    /// </summary>
    [JsonIgnore]
    public string Type { get; } = Type;
}
