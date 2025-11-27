namespace FeishuNetSdk.Im.Dtos;

/// <summary>
/// 表单事件交互
/// </summary>
/// <param name="Behavior">表单事件类型。
/// <list type="bullet">
/// <item>submit</item>
/// <item>reset</item>
/// </list>
/// </param>
[JsonPolymorphic(TypeDiscriminatorPropertyName = FeishuNetSdkOptions.Discriminator.Type,
    UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor,
    IgnoreUnrecognizedTypeDiscriminators = true)]
[JsonDerivedType(typeof(FormActionBehaviors), typeDiscriminator: "form_action")]
public record FormActionBehaviors([property: JsonPropertyName("behavior")] FormActionBehaviors.BehaviorType? Behavior = null) : Behaviors("form_action")
{
    /// <summary>
    /// 表单事件类型。
    /// </summary>
    [JsonConverter(typeof(SnakeCaseLowerConverter<BehaviorType>))]
    public enum BehaviorType
    {
        /// <summary>
        /// 提交整个表单
        /// </summary>
        Submit,

        /// <summary>
        /// 重置整个表单
        /// </summary>
        Reset
    }
}
