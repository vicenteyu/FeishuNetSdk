namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 消息卡片
    /// </summary>
    /// <param name="MessageType">消息类型固定为：interactive</param>
    public abstract record MessageCard([property: JsonIgnore] string MessageType = "interactive") : IHasMessageType;
}
