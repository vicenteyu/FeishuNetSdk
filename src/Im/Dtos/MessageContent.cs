namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// MessageContent
    /// </summary>
    /// <param name="MessageType">消息类型</param>
    public abstract record MessageContent([property: JsonIgnore] string MessageType) : IHasMessageType;
}
