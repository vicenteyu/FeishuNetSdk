namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 消息类型
    /// </summary>
    public interface IHasMessageType
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonIgnore]
        string MessageType { get; }
    }
}
